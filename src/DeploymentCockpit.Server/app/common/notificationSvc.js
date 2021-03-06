﻿"use strict";

app.factory("notificationSvc", function () {
    return {
        success: function (message) {
            console.log("[Success] " + message);
            toastr.success(message);
        },
        info: function (message) {
            console.log("[Info] " + message);
            toastr.info(message);
        },
        warning: function (message) {
            console.log("[Warning] " + message);
            toastr.warning(message);
        },
        error: function (message) {
            console.log("[Error] " + message);
            toastr.error(message);
        },
        errors: function (errors) {
            for (var i = 0; i < errors.length; i++) {
                this.error(errors[i]);
            }
        },

        saved: function (name) {
            console.log("[Saved] " + name);
            toastr.success(name, "Saved");
        },
        deleted: function (name) {
            console.log("[Deleted] " + name);
            toastr.success(name, "Deleted");
        },

        confirmDelete: function (name) {
            return confirm('Are you sure you want to delete "' + name + '"?');
        }
    };
});
