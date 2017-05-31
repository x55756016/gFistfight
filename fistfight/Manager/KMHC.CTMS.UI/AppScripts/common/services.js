
(function () {
    "use strict";
    var app = angular.module('HR.services', []);

    var services = ['users'
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
    ];// the services without customized actions
    function addService(name, actions) {
        app.factory(name + 'Services', ['$resource', function ($resource) {
            return $resource('/api/' + name + '/:id', null, actions);
        }]);
    }
    angular.forEach(services, function (name) {
        addService(name, null);
    });
    //addService('login_register', { login: { method: 'POST', url: '/api/authenticate' } });
})();