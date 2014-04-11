'use strict';

My.AngularJS.Module.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider
        .when('/', {
            templateUrl: '/app/home/home-view.html'
        })
        .when('/about', {
            templateUrl: '/app/home/about-view.html'
        })
        .otherwise({
            redirectTo: '/'
        });


    $locationProvider.html5Mode(true);

    console.log('initialized');
}]);
