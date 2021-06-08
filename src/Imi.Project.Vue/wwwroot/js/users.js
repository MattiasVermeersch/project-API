var baseUrl = 'https://localhost:5001/api/';
var usersUrl = `${baseUrl}Users`;
var token = sessionStorage.getItem('token');
var userId = sessionStorage.getItem('userId');
var userRole = sessionStorage.getItem('userRole');
const axiosConfig = { headers: { Authorization: `Bearer ${token}` } };

//TODO: create management page for logged in user only.

var app = new Vue({
    el: "#users",
    data: {
        users: null,
        currentUser: null,
        userToDelete: null,
        showUsers: false,
        selected: '',
        isDisabled: true,
        isEdit: false,
        loading: true,
        sessionUserId: userId,
        sessionUserRole: userRole,
    },
    created: function () {
        var self = this;
        self.fetchUsers();
    },
    methods: {
        fetchUsers: function () {
            var self = this;
            axios.get(`${usersUrl}`, axiosConfig)
                .then(function (response) {
                    self.users = response.data;
                    self.loading = false;
                    self.showUsers = true;
                })
                .catch(function (error) {
                    console.error(error)
                });
        },
        getUserDetails: function (user) {
            var self = this;
            user.birthDate = user.birthDate.substr(0, 10);
            self.currentUser = user;
            self.selected = user.roles[0];
            self.isDisabled = true;
            self.isEdit = false;
            self.showUsers = false;
        },
        editUserDetails: function (user) {
            var self = this;
            user.birthDate = user.birthDate.substr(0, 10);
            self.currentUser = user;
            self.selected = user.roles[0];
            self.isDisabled = false;
            self.showUsers = false;
            self.isEdit = true;
        },
        getUserList: function () {
            var self = this;
            self.showUsers = true;
            self.currentUser = null;
            self.userToDelete = null;
        },
        saveUserDetails: function (user) {
            var self = this;
            axios.put(usersUrl, self.currentUser, axiosConfig)
                .then(function (response) {
                    if (response.status == 200) {
                        self.getUserDetails(response.data);
                    }
                })
                .catch(function (error) {
                    console.error(error);
                });
        },
        deleteUser: function (user) {
            var self = this;
            self.showUsers = false;
            self.userToDelete = user;
        },
        confirmDelete: function (user) {
            var self = this;
            axios.delete(`${usersUrl}/${user.id}`, axiosConfig)
                .then(function (response) {
                    if (response.status == 200) {
                        self.fetchUsers();
                        self.showUsers = true;
                        self.userToDelete = null;
                    }
                })
                .catch(function (error) {
                    console.log(error);
                });
        }
    },
});