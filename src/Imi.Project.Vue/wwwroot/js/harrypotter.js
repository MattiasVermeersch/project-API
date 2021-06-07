var baseUrl = 'https://hp-api.herokuapp.com/api/';
var charactersUrl = `${baseUrl}characters/`;

var app = new Vue({
    el: "#harrypotter",
    data: {
        loading: true,
        characters: [],
        students: [],
        staff: [],
        charactersByHouse: [],
        currentCharacter: null,
        page: '',
        activeAllCharacters: false,
        activeStudents: false,
        activeStaff: false,
        activeHouses: false,
        showByHouse: false,
    },
    created: function () {
        var self = this;
        self.fetchCharacters();
        self.fetchStudents();
        self.fetchStaff();
        self.showAllCharacters();
        self.loading = false;
    },
    methods: {
        fetchCharacters: function () {
            var self = this;
            axios.get(`${charactersUrl}`)
                .then(function (response){
                    self.characters = response.data;
                    console.log(self.characters);
            });
        },
        fetchStudents: function () {
            var self = this;
            axios.get(`${charactersUrl}students`)
                .then(function (response) {
                    self.students = response.data;
                });
        },
        fetchStaff: function () {
            var self = this;
            axios.get(`${charactersUrl}staff`)
                .then(function (response) {
                    self.staff = response.data;
                });
        },
        fetchCharactersByHouse: function (house) {
            var self = this;
            axios.get(`${charactersUrl}house/${house}`)
                .then(function (response) {
                    self.charactersByHouse = response.data;
                });
        },
        showAllCharacters: function () {
            var self = this;
            self.currentCharacter = null;
            self.activeAllCharacters = true;
            self.activeStudents = false;
            self.activeStaff = false;
            self.activeHouses = false;
            self.showByHouse = false;
            self.charactersByHouse = [];
        },
        showAllStudents: function () {
            var self = this;
            self.currentCharacter = null;
            self.activeAllCharacters = false;
            self.activeStudents = true;
            self.activeStaff = false;
            self.activeHouses = false;
            self.showByHouse = false;
            self.charactersByHouse = [];
        },
        showAllStaff: function () {
            var self = this;
            self.currentCharacter = null;
            self.activeAllCharacters = false;
            self.activeStudents = false;
            self.activeStaff = true;
            self.activeHouses = false;
            self.showByHouse = false;
            self.charactersByHouse = [];
        },
        showAllHouses: function () {
            var self = this;
            self.currentCharacter = null;
            self.activeAllCharacters = false;
            self.activeStudents = false;
            self.activeStaff = false;
            self.activeHouses = true;
            self.showByHouse = false;
            self.charactersByHouse = [];
        },
        getCharacterDetails: function (character, page) {
            var self = this;
            self.loading = true;
            self.activeAllCharacters = false;
            self.activeStudents = false;
            self.activeStaff = false;
            self.activeHouses = false;
            self.page = page;
            self.currentCharacter = character;
            self.loading = false;
        },
        getCharactersByHouse: function (house) {
            var self = this;
            self.showByHouse = true;
            self.charactersByHouse = [];
            self.fetchCharactersByHouse(house);
        },
        returnToPage: function () {
            var self = this;
            if (self.page == 'characters') self.activeAllCharacters = true;
            else if (self.page == 'students') self.activeStudents = true;
            else if (self.page == 'staff') self.activeStaff = true;
            else if (self.page == 'houses') self.activeHouses = true;
            self.currentCharacter = null;
        },
    },
});