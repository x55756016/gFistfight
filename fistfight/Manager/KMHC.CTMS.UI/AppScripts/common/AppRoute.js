
angular.module('userApp', [
        'ngRoute',
        'ngResource',
        'HR.services',
        'Utility',
        'navigation.controllers'
                	, 'tm_pm_userinfo'
                	, 'xy_sp_chapter'
                	, 'xy_sp_equipment'
                	, 'xy_sp_map'
                	, 'xy_sp_skill'
                	, 'xy_sp_spirit'
                	, 'xy_sp_spiritequipment'
                	, 'xy_sp_spiritskill'
                	, 'xy_sp_task'
                	, 'xy_sp_taskoption'
                	, 'xy_sp_taskspirit'
                	, 'xy_sp_userinfo'
                	, 'xy_sp_userspirit'
]).
    config([
        '$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
            $routeProvider.when('/', {});
            $routeProvider.when('/tm_pm_userinfo', { templateUrl: '/Views/List/tm_pm_userinfo.html', controller: 'tm_pm_userinfoCtrl' });
            $routeProvider.when('/Addtm_pm_userinfo', { templateUrl: '/Views/Info/tm_pm_userinfo.html', controller: 'Addtm_pm_userinfoCtrl' });
            $routeProvider.when('/Edittm_pm_userinfo', { templateUrl: '/Views/Info/tm_pm_userinfo.html', controller: 'Addtm_pm_userinfoCtrl' });
            $routeProvider.when('/xy_sp_chapter', { templateUrl: '/Views/List/xy_sp_chapter.html', controller: 'xy_sp_chapterCtrl' });
            $routeProvider.when('/Addxy_sp_chapter', { templateUrl: '/Views/Info/xy_sp_chapter.html', controller: 'Addxy_sp_chapterCtrl' });
            $routeProvider.when('/Editxy_sp_chapter', { templateUrl: '/Views/Info/xy_sp_chapter.html', controller: 'Addxy_sp_chapterCtrl' });
            $routeProvider.when('/xy_sp_equipment', { templateUrl: '/Views/List/xy_sp_equipment.html', controller: 'xy_sp_equipmentCtrl' });
            $routeProvider.when('/Addxy_sp_equipment', { templateUrl: '/Views/Info/xy_sp_equipment.html', controller: 'Addxy_sp_equipmentCtrl' });
            $routeProvider.when('/Editxy_sp_equipment', { templateUrl: '/Views/Info/xy_sp_equipment.html', controller: 'Addxy_sp_equipmentCtrl' });
            $routeProvider.when('/xy_sp_map', { templateUrl: '/Views/List/xy_sp_map.html', controller: 'xy_sp_mapCtrl' });
            $routeProvider.when('/Addxy_sp_map', { templateUrl: '/Views/Info/xy_sp_map.html', controller: 'Addxy_sp_mapCtrl' });
            $routeProvider.when('/Editxy_sp_map', { templateUrl: '/Views/Info/xy_sp_map.html', controller: 'Addxy_sp_mapCtrl' });
            $routeProvider.when('/xy_sp_skill', { templateUrl: '/Views/List/xy_sp_skill.html', controller: 'xy_sp_skillCtrl' });
            $routeProvider.when('/Addxy_sp_skill', { templateUrl: '/Views/Info/xy_sp_skill.html', controller: 'Addxy_sp_skillCtrl' });
            $routeProvider.when('/Editxy_sp_skill', { templateUrl: '/Views/Info/xy_sp_skill.html', controller: 'Addxy_sp_skillCtrl' });
            $routeProvider.when('/xy_sp_spirit', { templateUrl: '/Views/List/xy_sp_spirit.html', controller: 'xy_sp_spiritCtrl' });
            $routeProvider.when('/Addxy_sp_spirit', { templateUrl: '/Views/Info/xy_sp_spirit.html', controller: 'Addxy_sp_spiritCtrl' });
            $routeProvider.when('/Editxy_sp_spirit', { templateUrl: '/Views/Info/xy_sp_spirit.html', controller: 'Addxy_sp_spiritCtrl' });
            $routeProvider.when('/xy_sp_spiritequipment', { templateUrl: '/Views/List/xy_sp_spiritequipment.html', controller: 'xy_sp_spiritequipmentCtrl' });
            $routeProvider.when('/Addxy_sp_spiritequipment', { templateUrl: '/Views/Info/xy_sp_spiritequipment.html', controller: 'Addxy_sp_spiritequipmentCtrl' });
            $routeProvider.when('/Editxy_sp_spiritequipment', { templateUrl: '/Views/Info/xy_sp_spiritequipment.html', controller: 'Addxy_sp_spiritequipmentCtrl' });
            $routeProvider.when('/xy_sp_spiritskill', { templateUrl: '/Views/List/xy_sp_spiritskill.html', controller: 'xy_sp_spiritskillCtrl' });
            $routeProvider.when('/Addxy_sp_spiritskill', { templateUrl: '/Views/Info/xy_sp_spiritskill.html', controller: 'Addxy_sp_spiritskillCtrl' });
            $routeProvider.when('/Editxy_sp_spiritskill', { templateUrl: '/Views/Info/xy_sp_spiritskill.html', controller: 'Addxy_sp_spiritskillCtrl' });
            $routeProvider.when('/xy_sp_task', { templateUrl: '/Views/List/xy_sp_task.html', controller: 'xy_sp_taskCtrl' });
            $routeProvider.when('/Addxy_sp_task', { templateUrl: '/Views/Info/xy_sp_task.html', controller: 'Addxy_sp_taskCtrl' });
            $routeProvider.when('/Editxy_sp_task', { templateUrl: '/Views/Info/xy_sp_task.html', controller: 'Addxy_sp_taskCtrl' });
            $routeProvider.when('/xy_sp_taskoption', { templateUrl: '/Views/List/xy_sp_taskoption.html', controller: 'xy_sp_taskoptionCtrl' });
            $routeProvider.when('/Addxy_sp_taskoption', { templateUrl: '/Views/Info/xy_sp_taskoption.html', controller: 'Addxy_sp_taskoptionCtrl' });
            $routeProvider.when('/Editxy_sp_taskoption', { templateUrl: '/Views/Info/xy_sp_taskoption.html', controller: 'Addxy_sp_taskoptionCtrl' });
            $routeProvider.when('/xy_sp_taskspirit', { templateUrl: '/Views/List/xy_sp_taskspirit.html', controller: 'xy_sp_taskspiritCtrl' });
            $routeProvider.when('/Addxy_sp_taskspirit', { templateUrl: '/Views/Info/xy_sp_taskspirit.html', controller: 'Addxy_sp_taskspiritCtrl' });
            $routeProvider.when('/Editxy_sp_taskspirit', { templateUrl: '/Views/Info/xy_sp_taskspirit.html', controller: 'Addxy_sp_taskspiritCtrl' });
            $routeProvider.when('/xy_sp_userinfo', { templateUrl: '/Views/List/xy_sp_userinfo.html', controller: 'xy_sp_userinfoCtrl' });
            $routeProvider.when('/Addxy_sp_userinfo', { templateUrl: '/Views/Info/xy_sp_userinfo.html', controller: 'Addxy_sp_userinfoCtrl' });
            $routeProvider.when('/Editxy_sp_userinfo', { templateUrl: '/Views/Info/xy_sp_userinfo.html', controller: 'Addxy_sp_userinfoCtrl' });
            $routeProvider.when('/xy_sp_userspirit', { templateUrl: '/Views/List/xy_sp_userspirit.html', controller: 'xy_sp_userspiritCtrl' });
            $routeProvider.when('/Addxy_sp_userspirit', { templateUrl: '/Views/Info/xy_sp_userspirit.html', controller: 'Addxy_sp_userspiritCtrl' });
            $routeProvider.when('/Editxy_sp_userspirit', { templateUrl: '/Views/Info/xy_sp_userspirit.html', controller: 'Addxy_sp_userspiritCtrl' });

            $routeProvider.otherwise({ redirectTo: '/' });
        }
    ]).controller('MyController', function ($scope, $http) {
        $scope.logout = function () {
            $http({
                method: 'POST',
                url: '/User/UserLogout'
            }).success(function (data) {
                alert(data.Msg);
                window.location = "/User/Login#/Login";
            }).error(function (data) {
                alert(data);
            });
        };
    });

