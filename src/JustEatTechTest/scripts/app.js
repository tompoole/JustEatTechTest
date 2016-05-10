var justEatTechTest = angular.module("justEatTechTest", []);

// Service that wraps the HTTP request
justEatTechTest.factory("restaurantSearchService", ["$http", function ($http) {

    function getByOutcode(outcode) {
        var url = '/api/restaurants/get?outcode=' + outcode;
        return $http.get(url); // returns http promise, rather than actual result.
    }

    return {
        getByOutcode: getByOutcode
    };

}]);

justEatTechTest.controller("restaurantSearchController", ["restaurantSearchService", function (restaurantSearchService) {
    var vm = this,
        searchOutcode = "";

    function searchSuccess(response) {
        var results = response.data.Data;

        vm.searchOutcode = searchOutcode;
        vm.formHasError = false;
        vm.results = results;
    }

    function searchError(response) {
        var errorMessage = response.data.Message;
        
        // if there's additional information about the error, add it to the message
        if (response.data.ExceptionMessage && response.data.ExceptionMessage.length) {
            errorMessage += " - " + response.data.ExceptionMessage;
        }

        vm.formHasError = true;
        vm.errorMessage = errorMessage;
    }

    function performSearch() {
        searchOutcode = vm.outcode;
        restaurantSearchService.getByOutcode(vm.outcode).then(searchSuccess, searchError);
    }

    vm.performSearch = performSearch;
}]);