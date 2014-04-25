My.AngularJS.Module.directive('jumbotron', [function () {
    return {
        restrict: 'E',
        replace: true,
        transclude: true,
        scope: {
            title: '@',
            lead: '@'
        },
        template: '<div class="jumbotron"><h1>{{ title }}</h1><p class="lead">{{ lead }}</p><p data-ng-transclude></p></div>'
    };
}]);
