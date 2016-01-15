(function() {

  "use strict";

  /**
   * @ngdoc function
   * @name webApiSample.controller:HomeCtrl
   * @description
   * # HomeCtrl
   * Controller of the webApiSample
   */
  angular
    .module("travelSite")
    .controller("imageUploadController", ["$window",
      "fileService", "Upload", "apiUrl", function($window, fileService, Upload, apiUrl) {

        var vm = this;

        //Variables
        vm.photos = [];
        vm.files = [];
        vm.previewPhoto = {};
        vm.spinner = {
          active: true
        };

        //Functions
        function setPreviewPhoto(photo) {
          vm.previewPhoto = photo;
        }

        function activate() {
          vm.spinner.active = true;
          fileService.getAll()
            .then(function (data) {
              vm.photos = data.Photos;
              vm.spinner.active = false;
              setPreviewPhoto();
            }, function(err) {
              console.log("Error status: " + err.status);
              vm.spinner.active = false;
            });
        }

        function uploadFiles(files) {
          Upload.upload({
              url: apiUrl,
              data: { file: files }
            })
            .then(function(response) {

              activate();
              setPreviewPhoto();
       
            }, function(err) {
              console.log("Error status: " + err.status);
              vm.spinner.active = false;
            });

          $window.location.reload();
        }

        function removePhoto(photo) {
          fileService.deletePhoto(photo.Name)
            .then(function() {
              activate();

              setPreviewPhoto();
            });
        }

        //Set scope 
        activate();
        vm.uploadFiles = uploadFiles;
        vm.remove = removePhoto;
        vm.setPreviewPhoto = setPreviewPhoto;
      }
    ]);
})();