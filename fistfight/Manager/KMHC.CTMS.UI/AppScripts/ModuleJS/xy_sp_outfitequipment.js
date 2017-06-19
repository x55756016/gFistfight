var app = angular.module('xy_sp_outfitequipment', []);

app.controller('xy_sp_outfitequipmentCtrl', ['$scope', '$http', '$filter','$location', '$routeParams', 'xy_sp_outfitequipmentServices',
        function ($scope, $http,$filter, $location, $routeParams, xy_sp_outfitequipmentServices) {

            //搜索、分页列表
            $scope.CurrentPage = 1;
            $scope.Search = function () {
                $scope.loading = true;
                xy_sp_outfitequipmentServices.get({ CurrentPage: $scope.CurrentPage }, function (data) {
                    $scope.List = data.Data;
                    $scope.loading = false;
                    var pager = new Pager('pager', $scope.CurrentPage, data.PagesCount, function (curPage) {
                        $scope.CurrentPage = parseInt(curPage);
                        $scope.Search();
                    });
                },
                    function (data) {
                        $scope.List = [];
                        $scope.loading = false;
                    }
                );
            };
			
			//  新增
            $scope.Add = function () {
                $location.url('/Addxy_sp_outfitequipment');
            };
            
            //编辑
            $scope.Edit = function (obj) {
                $location.url('/Editxy_sp_outfitequipment?id='+ obj.OutfitEquipmentID);
            };
			
			//删除
            $scope.Remove = function (obj) {
                if (!confirm('确认删除？')) return;

                $http.delete('/Api/xy_sp_outfitequipment?id=' + obj.OutfitEquipmentID).success(function (data) {
                    if (data != "ok") {
                        alert('删除失败');
                    } else {
                        $scope.Search();
                    }
                });
            }

            $scope.Search();

        }
]);


app.controller('Addxy_sp_outfitequipmentCtrl', ['$scope', '$http', '$filter','$location', '$routeParams',
    function ($scope, $http,$filter, $location, $routeParams) {
        $scope.SelectInfo = [{ text: "是", value: true }, { text: "否", value: false }];

        if ($routeParams.id != undefined) {
            $http.get('/Api/xy_sp_outfitequipment?ID=' + $routeParams.id).success(function (data) {
                $scope.Info = data;            
            });
        }

        $scope.Save = function () {
            $http.post('/Api/xy_sp_outfitequipment', { Data: $scope.Info }).success(function (data) {
                if (data == 'ok')
                    alert('保存成功');
                else
                    alert('网络异常');
            });
        };

        $scope.GoBack = function () {
            $location.url('xy_sp_outfitequipment');
        };
    }
]);