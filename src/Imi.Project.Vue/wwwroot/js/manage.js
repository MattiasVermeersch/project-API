var baseUrl = 'https://localhost:5001/api/';
var usersUrl = `${baseUrl}Users`;
var token = sessionStorage.getItem('token');
var userId = sessionStorage.getItem('userId');
const axiosConfig = { headers: { Authorization: `Bearer ${token}` } };

//TODO: create management page for logged in user only.

var app = new Vue({
    el: "#manage",
    data: {
        currentUser: null,
        userToDelete: null,
        isDisabled: true,
        isEdit: false,
        loading: true,
    },
    created: function () {
        var self = this;
        self.fetchUser();
    },
    methods: {
        fetchUser: function () {
            var self = this;
            axios.get(`${usersUrl}/${userId}`, axiosConfig)
                .then(function (response) {
                    let user = response.data;
                    user.birthDate = user.birthDate.substr(0, 10);
                    self.currentUser = user;
                    self.isEdit = false;
                    self.isDisabled = true;
                    self.userToDelete = null;
                    self.loading = false;
                })
                .catch(function (error) {
                    console.error(error)
                });
        },
        editUserDetails: function (user) {
            var self = this;
            user.birthDate = user.birthDate.substr(0, 10);
            self.currentUser = user;
            self.isDisabled = false;
            self.isEdit = true;
        },
        saveUserDetails: function (user) {
            var self = this;

            axios.put(usersUrl, self.currentUser, axiosConfig)
                .then(function (response) {
                    if (response.status == 200) {
                        self.fetchUser();
                    }
                })
                .catch(function (error) {
                    console.error(error);
                });
        },
        deleteUser: function (user) {
            var self = this;
            self.showUsers = false;
            self.currentUser = null;
            self.userToDelete = user;
        },
        confirmDelete: function (user) {
            var self = this;
            console.log(`${usersUrl}/${user.id}`);
            axios.delete(`${usersUrl}/${user.id}`, axiosConfig)
                .then(function (response) {
                    console.log(response);
                    if (response.status == 200) {
                        self.logout();
                    }
                })
                .catch(function (error) {
                    console.log(error);
                });
        },
        logout: function () {
            sessionStorage.clear();
            window.location.href = 'Login';
        },
    },
});