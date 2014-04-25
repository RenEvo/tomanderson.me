'use strict';

My.AngularJS.Module.run(['$rootScope', function ($rootScope) {
    
    var site = {
        name: 'My Angular Site',
        copyright: '2014 - Your Company Here'
    };

    $rootScope.site = site;

}]);
