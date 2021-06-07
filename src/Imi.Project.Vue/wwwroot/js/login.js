var baseUrl = 'https://localhost:5001/api/';
var apiLogin = `${baseUrl}auth/login`;
var apiRegister = `${baseUrl}auth/register`;

var app = new Vue({
    el: "#index",
    data: {
        isLogin: true,
        isRegister: false,
        login: { email: "ageydon0@marriott.com", password: "Test123?" },
        newLogin: { email: "", password: ""},
        newUser: {
            firstName: "Kim",
            lastName: "Vanhollebeke",
            email: "user@example.com",
            password: "Test123?",
            confirmPassword: "Test123?",
            city: "Aartrijke",
            address: "Brugse Heirweg 7",
            birthDate: new Date("1992-04-05").toISOString().substr(0, 10),
        },
        errorMessage: null,
        loading: false,
    },
    created: function () {

    },
    methods: {
        loginForm: function (showLogin) {
            var self = this;
            self.isLogin = showLogin;
            self.isRegister = !showLogin;
        },
        loginUser: function (login) {
            var self = this;
            self.errorMessage = null;
            self.isLogin = false;
            self.loading = true;
            axios
                .post(apiLogin, login)
                .then((response) => {
                    if (response.status == 200) {
                        self.handleSessionStorage(response.data);
                        window.location.href = '/Home/Characters';
                    }
                    else {
                        self.errorMessage = response.data.status;
                        self.isLogin = true;
                    }
                })
                .catch(error => self.errorMessage = error);
        },
        registerUser: function (newUser) {
            var self = this;
            console.log(newUser);
            newUser.birthDate = newUser.birthDate.substr(0, 10);
            axios
                .post(apiRegister, newUser)
                .then((response) => {
                    if (response.status == 200) {
                        self.isLogin = true;
                        newLogin = {
                            email: response.data.email,
                            password: newUser.password
                        };
                        self.loginUser(newLogin);
                    } else {
                        self.errorMessage = response.data.status;
                    }
                })
                .catch(error => self.errorMessage = error);
        },
        jWTTokenParse: function (JWTtoken) {
            try {
                //split function to splice the token in three parts. According to theory "roles" are found in the payload.
                //Payload can be found in the second part of the token, Index = 1
                //token is encoded with Base64url, to decode this there is a function atob().
                //last thing to add, to make object from atob a JSON object => JSON.parse()
                let parsedToken = JSON.parse(atob(JWTtoken.split('.')[1]));
                return parsedToken;
                //REMINDER: claims can also be found in the payload of the token!!!
            }
            catch (error) {
                return error;
            }
        },
        getRoleFromToken: function (parsedToken) {
            //property of the role = http://schemas.microsoft.com/ws/2008/06/identity/claims/role
            let role = parsedToken["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
            return role;
        },
        handleSessionStorage: function (responseData) {
            var self = this;
            let token = responseData.token;
            let userRole = self.getRoleFromToken(self.jWTTokenParse(token));
            let userId = responseData.userId;

            sessionStorage.setItem('token', token);
            sessionStorage.setItem('userId', userId);
            sessionStorage.setItem('userRole', userRole);
        }

    },
});