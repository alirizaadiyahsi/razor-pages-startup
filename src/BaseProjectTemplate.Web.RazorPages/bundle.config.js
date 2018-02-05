//Alternative

module.exports = {
  libsFolder: "./wwwroot/lib",
  mappings: {
    "node_modules/bootstrap/dist/css/bootstrap.css": "bootstrap/dist/css",
    "node_modules/bootstrap/dist/js/bootstrap.js": "bootstrap/dist/js",
    "node_modules/jquery/dist/jquery.js": "jquery/dist",
    "node_modules/jquery-validation/dist/jquery.validate.js": "jquery-validation/dist",
    "node_modules/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js": "jquery-validation-unobtrusive"
  },
  bundles: [

      // common resources
      {
          "outputFileName": "wwwroot/css/site.min.css",
          "inputFiles": [
              "wwwroot/css/site.css"
          ]
      },
      {
          "outputFileName": "wwwroot/js/site.min.js",
          "inputFiles": [
              "wwwroot/js/site.js"
          ]
      },
      {
          "outputFileName": "wwwroot/css/admin/admin-site.min.css",
          "inputFiles": [
              "wwwroot/css/admin/admin-site.css"
          ]
      },
      {
          "outputFileName": "wwwroot/js/admin/admin-site.min.js",
          "inputFiles": [
              "wwwroot/js/admin/admin-site.js"
          ]
      },

      // pages resources
      {
          "outputFileName": "wwwroot/pages/_bundles/layout.min.css",
          "inputFiles": [
              "wwwroot/lib/bootstrap/dist/css/bootstrap.css"
          ]
      },
      {
          "outputFileName": "wwwroot/pages/_bundles/layout.min.js",
          "inputFiles": [
              "wwwroot/lib/jquery/dist/jquery.js",
              "wwwroot/lib/bootstrap/dist/js/bootstrap.js"
          ]
      },
      {
          "outputFileName": "wwwroot/pages/_bundles/validation-scripts.min.js",
          "inputFiles": [
              "wwwroot/lib/jquery-validation/dist/jquery.validate.js",
              "wwwroot/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"
          ]
      }
  ]
};
