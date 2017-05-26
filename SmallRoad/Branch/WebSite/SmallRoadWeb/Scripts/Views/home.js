﻿var app = angular.module("HomeApp", ['ui.bootstrap']);

app.controller('HomeController', function ($scope, $http) {

    $scope.logar = function () {
        $http({
            url: '/Usuario/Logar',
            method: 'POST',
            data: { Usuario: $scope.Usuario }
        })
            .success(function (data, status, headers, config) {

                if (data == "") {
                    alert("Usuário ou senha inválidos");
                } else {
                    if (data.TipoUsuario == "G")
                        window.location = "/RoteiroGerente/";
                    else
                        window.location = "/RoteiroMotorista/";
                }
            })
            .error(function (data, status, headers, config) {
                // Lança o erro no console do navegador caso ocorra
                console.log("Erro: " + status + "\nConfig: " + JSON.stringify(config) + "\nData:\n" + data);
            });
    };

});

