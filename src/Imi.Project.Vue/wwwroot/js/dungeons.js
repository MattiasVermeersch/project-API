var baseUrl = 'https://localhost:5001/api/';
var dungeonsUrl = `${baseUrl}Dungeons`;
var usersUrl = `${baseUrl}Users`;
var token = sessionStorage.getItem('token');
var userId = sessionStorage.getItem('userId');
var role = sessionStorage.getItem('userRole');
const axiosConfig = { headers: { Authorization: `Bearer ${token}` } };

var app = new Vue({
    el: "#dungeons",
    data: {
        loading: true,
        isAdmin: false,
        showDungeons: false,
        upcomingDungeons: [],
        pastDungeons: [],
        currentDungeon: null,
        dungeonIdInput: '',
        udEmpty: false,
        pdEmpty: false,
        isDisabled: true,
        isPast: false,
        hasCharacters: true,
        isFullDungeon: false,
        toAddCharacter: false,
        characters: [],
        allCharacters: [],
        selectedCharacter: null,
        userHasNoCharacterSigned: true,
        dungeonForCharacter: null,
        newDungeon:
        {
            instanceName: '',
            difficulty: "Normal",
            date: null,
            success: false,
            mythicKey: 0,
            characters: [],
        },
        difficultySelect: null,
        isMythicPlus: false,
        sessionUserId: userId,
        characterInput: {
            id: '',
            name: '',
            class: '',
            role: '',
            level: 0,
            itemLevel: 0,
            arenaRating: 0,
            battlegroundRating: 0,
            userId: ''
        }
    },
    created: function () {
        var self = this;
        self.fetchDungeons();
        if (role === 'Admin') { isAdmin = true;}
    },
    methods: {
        fetchDungeons: function () {
            var self = this;
            self.loading = true;
            axios.get(`${dungeonsUrl}`, axiosConfig)
                .then(function (response) {
                    let dungeons = response.data;
                    let today = new Date();

                    dungeons.forEach(function (dungeon) {
                        let dungeonDate = new Date(dungeon.date.toString());
                        if (dungeonDate < today) {
                            dungeon.date = self.formatDate(dungeon.date);
                            self.pastDungeons.push(dungeon);
                        }
                        else {
                            dungeon.date = self.formatDate(dungeon.date);
                            self.upcomingDungeons.push(dungeon);
                        }
                    });
                    if (self.upcomingDungeons.length === 0) self.udEmpty = true;
                    if (self.pastDungeons.length === 0) self.pdEmpty = true;
                    self.showDungeons = true;
                    self.loading = false;
                })
                .catch(function (error) {
                    console.error(error)
                });
        },
        getDungeonDetails: function (dungeon) {
            var self = this;
            dungeon.date = self.formatDateInput(dungeon.date);
            dungeon.characters.sort(self.sortArray);

            let dungeonDifficulty = dungeon.difficulty;
            let diffArray = dungeonDifficulty.split(' ');

            if (diffArray.length > 1) {
                dungeon.difficulty = diffArray[0];
                dungeon.mythicKey = diffArray[1];
            }

            self.difficultySelect = dungeon.difficulty;
            self.getDifficulty();
            if (dungeon.characters.length < 1) { self.hasCharacters = false; }
            else { self.hasCharacters = true; }
            self.currentDungeon = dungeon;
            self.dungeons = null;
            self.pastDungeons = [];
            self.upcomingDungeons = [];
            self.showDungeons = false;
            self.isPast = true;
            self.isFullDungeon = true;
            self.toAddCharacter = false;
        },
        getUpcomingDungeonDetails: function (dungeon) {
            var self = this;
            dungeon.date = self.formatDateInput(dungeon.date);
            dungeon.characters.sort(self.sortArray);

            let dungeonDifficulty = dungeon.difficulty;
            let diffArray = dungeonDifficulty.split(' ');

            if (diffArray.length > 1) {
                dungeon.difficulty = diffArray[0];
                dungeon.mythicKey = diffArray[1];
            }

            self.difficultySelect = dungeon.difficulty;
            self.getDifficulty();
            self.checkHasCharacters(dungeon.characters);

            if (dungeon.characters.length == 5) { self.isFullDungeon = true; }
            else { self.isFullDungeon = false; }

            self.currentDungeon = dungeon;
            self.dungeons = null;
            self.pastDungeons = [];
            self.upcomingDungeons = [];
            self.showDungeons = false;
            self.isPast = false;
        },
        getDungeonList: function () {
            var self = this;
            self.currentDungeon = null;
            self.characters = [];
            self.fetchDungeons();
            self.showDungeons = true;
            self.toAddCharacter = false;
        },
        showCreateForm: function (newDungeon) {
            var self = this;
            self.isDisabled = false;
            self.isMythicPlus = false;
            self.currentDungeon = newDungeon;
            self.difficultySelect = newDungeon.difficulty;
            self.showDungeons = false;
        },
        createDungeon: function (dungeon) {
            var self = this;
            let mythicKey = dungeon.mythicKey.toString();
            console.log(mythicKey);
            if (self.difficultySelect === "Mythic+") {
                dungeon.difficulty = self.difficultySelect + ' ' + mythicKey;
            }
            else {
                dungeon.difficulty = self.difficultySelect;
            }
            axios.post(dungeonsUrl, dungeon, axiosConfig)
                .then((response) => {
                    if (response.status == 201) {
                        self.currentDungeon = false;
                        self.upcomingDungeons = [];
                        self.pastDungeons = [];
                        self.fetchDungeons();
                        self.isDisabled = true;
                    }
                })
                .catch(error => console.log(error));
        },
        addCharacter: function (dungeon) {
            var self = this;
            self.toAddCharacter = true;
            self.dungeonForCharacter = dungeon;
            self.currentDungeon = null;
            self.characters = [];
            self.selectedCharacter = null;
            self.fetchCharacters();
        },
        confirmCharacter: function (dungeon) {
            var self = this;
            let characterId = self.selectedCharacter;
            self.characterInput.id = characterId;
            let dungeonId = self.dungeonForCharacter.id;
            axios.put(`${dungeonsUrl}/${dungeonId}/Character`, self.characterInput, axiosConfig)
                .then(function (response) {
                    if (response.status == 200) {
                        console.log(response.data);
                        let updatedDungeon = response.data;
                        updatedDungeon.date = self.formatDateInput(self.formatDate(updatedDungeon.date));
                        self.currentDungeon = updatedDungeon;
                        self.toAddCharacter = false;
                        self.userHasNoCharacterSigned = false;
                        self.checkHasCharacters(updatedDungeon.characters);
                    }
                })
                .catch(function (error) {
                    console.error('console.error: ' + error);
                    console.log('Console.log: ' + error.response.data);
                });
        },
        deleteCharacterFromDungeon: function (character, dungeon) {
            var self = this;
            let characterId = character.id;
            let dungeonId = dungeon.id;
            axios.delete(`${dungeonsUrl}/${dungeonId}/character/${characterId}`, axiosConfig)
                .then(function (response) {
                    console.log('Response: ' + response.data);
                    if (response.status == 200) {
                        let updatedDungeon = response.data;
                        updatedDungeon.date = self.formatDateInput(self.formatDate(updatedDungeon.date));
                        self.currentDungeon = updatedDungeon;
                        self.userHasNoCharacterSigned = true;
                        self.checkHasCharacters(updatedDungeon.characters);
                    }
                })
                .catch(function (error) {
                    console.error('console.error: ' + error);
                    console.log('Console.log: ' + error.response.data);
                });
        },
        formatDate: function (dateInput) {
            let date = new Date(dateInput);
            let dd = date.getDate().toString().padStart(2,'0');
            let mm = (date.getMonth() + 1).toString().padStart(2,'0');
            let yy = date.getFullYear();

            let formattedDate = dd + '/' + mm + '/' + yy;
            return formattedDate;
        },
        formatDateInput: function (date) {
            let day = date.substr(0, 2);
            let month = date.substr(3, 2);
            let year = date.substr(6, 4);
            let newDate = year + '-' + month + '-' + day;
            return newDate;
        },
        sortArray: function (a, b) {
            if (a.role < b.role) {
                return 1;
            }
            if (a.role > b.role) {
                return -1;
            }
            return 0;
        },
        getDifficulty: function () {
            var self = this;
            if (self.difficultySelect === "Mythic+") {
                self.isMythicPlus = true;
            }
            else {
                self.isMythicPlus = false;
            }
        },
        fetchCharacters: function () {
            var self = this;
            axios.get(`${usersUrl}/${userId}/Characters`, axiosConfig)
                .then(function (response) {
                    self.allCharacters = response.data;
                    if (self.allCharacters.length == 0) {
                        self.characters = null;
                    }
                    self.allCharacters.forEach(function (character) {
                        if (!character.isDeleted) {
                            self.characters.push(character);
                        }
                    });
                })
                .catch(function (error) {
                    console.error(error)
                });
        },
        checkHasCharacters: function (characters) {
            var self = this;
            if (characters == null) self.hasCharacters = false;
            else {
                let characterArray = characters;
                if (characterArray.length < 1) { self.hasCharacters = false; }
                else {
                    self.hasCharacters = true;
                    characterArray.forEach(character => {
                        if (character.userId === userId) {
                            self.userHasNoCharacterSigned = false;
                        }
                    });
                }
            }
            
        },
    },
});