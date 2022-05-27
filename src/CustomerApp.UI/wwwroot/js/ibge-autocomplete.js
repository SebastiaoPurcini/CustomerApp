$(function () {
    /*$("#stateId").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Customer/GetStates",
                type: "GET",
                data: {
                    search: request.term
                },
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            label: item
                        }
                    }));
                }
            });
        },
        minLength: 1,
        select: function (event, ui) {
            document.getElementById('cityId').disabled = false;
        }
    });*/
    $("#cityId").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Customer/GetCities",
                type: "GET",
                data: {
                    search: request.term,
                    state: $("#stateId").val()
                },
                contentType: "application/json;charset=utf-8",
                dataType: "json",
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            label: item
                        }
                    }));
                }
            });
        },
        minLength: 3,
        select: function (event, ui) {
        }
    });
});