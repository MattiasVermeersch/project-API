var baseUrl = 'https://localhost:5001/api/';
var charactersUrl = `${baseUrl}Characters`;
var usersUrl = `${baseUrl}Users`;
var token = sessionStorage.getItem('token');
var userId = sessionStorage.getItem('userId');
const axiosConfig = { headers: { Authorization: `Bearer ${token}` } };

var app = new Vue({
    el: "#characters",
    data: {
        characters: [],
        currentCharacter: null,
        classSelected: '',
        roleSelected: '',
        showCharacters: false,
        loading: true,
        isDisabled: true,
        isEdit: false,
        toEdit: false,
        isRegister: false,
        roles: [],
        characterToDelete: null,
        newCharacter:
        {
            name: "",
            class: "",
            level: 0,
            itemLevel: 0,
            arenaRating: 0,
            battlegroundRating: 0,
            userId: ""
        },
    },
    created: function () {
        var self = this;
        self.fetchCharacters();
    },
    methods: {
        fetchCharacters: function () {
            var self = this;
            axios.get(`${usersUrl}/${userId}/Characters`, axiosConfig)
                .then(function (response) {
                    let characters = response.data;
                    if (characters.length == 0) {
                        self.characters = null;
                    }
                    characters.forEach(function (character) {
                        if (!character.isDeleted) {
                            self.characters.push(character);
                        }
                    });
                    self.loading = false;
                    self.showCharacters = true;
                })
                .catch(function (error) {
                    console.error(error)
                });
        },
        getCharacterDetails: function (character) {
            var self = this;
            self.currentCharacter = character;
            self.classSelected = character.class;
            self.isDisabled = true;
            self.toEdit = true;
            self.isEdit = false;
            self.isRegister = false;
            self.showCharacters = false;
        },
        editCharacterDetails: function (character) {
            var self = this;
            self.currentCharacter = character;
            self.classSelected = character.class;

            self.getRoleOptions();
            
            self.isDisabled = false;
            self.showCharacters = false;
            self.isEdit = true;
            self.toEdit = false;
        },
        getCharacterList: function () {
            var self = this;
            self.showCharacters = true;
            self.currentCharacter = null;
            self.characterToDelete = null;
        },
        saveCharacterDetails: function (character) {
            var self = this;
            axios.put(charactersUrl, character, axiosConfig)
                .then(function (response) {
                    if (response.status == 200) {
                        self.getCharacterDetails(response.data);
                    }
                })
                .catch(function (error) {
                    console.error(error);
                });
        },
        deleteCharacter: function (character) {
            var self = this;
            self.showCharacters = false;
            self.characterToDelete = character;
        },
        confirmDelete: function (character) {
            var self = this;
            axios.delete(`${charactersUrl}/${character.id}`, axiosConfig)
                .then(function (response) {
                    console.log(response);
                    if (response.status == 200) {
                        self.characters = [];
                        self.fetchCharacters();
                        self.showCharacters = true;
                        self.characterToDelete = null;
                    }
                })
                .catch(function (error) {
                    console.log(error);
                });
        },
        showCreateForm: function (newCharacter) {
            var self = this;
            self.currentCharacter = newCharacter;
            self.isRegister = true;
            self.toEdit = false;
            self.isEdit = false;
            self.getRoleOptions();
            self.isDisabled = false;
            self.showCharacters = false;
        },
        createCharacter: function (character) {
            var self = this;
            character.userId = userId;
            character.class = self.classSelected;
            axios.post(charactersUrl, character, axiosConfig)
                .then((response) => {
                    if (response.status == 201) {
                        self.loading = true;
                        self.currentCharacter = null;
                        self.characters = [];
                        self.fetchCharacters();
                        self.isDisabled = true;
                        self.isEdit = false;
                        self.toEdit = false;
                        self.isRegister = false;
                    }
                })
                .catch(error => self.errorMessage = error);
        },
        getRoleOptions: function () {
            var self = this;
            self.roles = [];
            if (self.classSelected == "Death Knight" ||
                self.classSelected == "Demon Hunter" ||
                self.classSelected == "Warrior") {
                self.roles = ["Dps", "Tank"];
            }
            else if (self.classSelected == "Priest" ||
                self.classSelected == "Shaman") {
                self.roles = ["Dps", "Healer"];
            }
            else if (self.classSelected == "Druid" ||
                self.classSelected == "Monk" ||
                self.classSelected == "Paladin") {
                self.roles = ["Dps", "Healer", "Tank"];
            }
            else {
                self.roles = ["Dps"];
            }
        },
    },
});