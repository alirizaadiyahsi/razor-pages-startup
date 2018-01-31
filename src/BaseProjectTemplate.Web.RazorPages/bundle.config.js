//Alternative

module.exports = {
  libsFolder: './wwwroot/lib',
  mappings: {
    "node_modules/bootstrap/dist/css": "bootstrap/dist/css"
  },
  bundles: [
      {
        outputFileName: 'wwwroot/view-resources/Areas/AppAreaName/Views/_Bundles/common-styles.css',
        inputFiles: [
            'wwwroot/Common/Styles/**/*.css',
            'wwwroot/fonts/**/*.css',
            '!wwwroot/Common/Styles/**/*.min.css'
        ]
      },
      {
        outputFileName: 'wwwroot/view-resources/Areas/AppAreaName/Views/_Bundles/common-scripts.js',
        inputFiles: [
            "wwwroot/Common/Scripts/**/*.js",
            "!wwwroot/Common/Scripts/**/*min.js"
        ]
      },
      {
        outputFileName: "wwwroot/js/views/home/index.min.js",
        inputFiles: [
            "wwwroot/js/views/home/index.js"
        ]
      },
      {
        outputFileName: "wwwroot/view-resources/Areas/AppAreaName/Views/AuditLogs/Index.min.css",
        inputFiles: [
            "wwwroot/view-resources/Areas/AppAreaName/Views/AuditLogs/Index.css"
        ]
      }
  ]
};