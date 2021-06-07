// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var role = sessionStorage.getItem("userRole");
var token = sessionStorage.getItem("token");

var app = new Vue({
    el: "#navbar",
    data: {
        role: role,
        token: token,
    },
    created: function () {

    },
    methods: {
        logout: function () {
            sessionStorage.clear();
            window.location.href= 'Login';
        },
        manageAccount: function () {
            window.location.href = 'Manage';
        }
    },
});