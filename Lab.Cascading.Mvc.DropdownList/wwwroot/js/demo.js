(function () {

    $(document).ready(function () {
        var items = "<option value='0'>Select</option>";
        $('#SubCategoryID').html(items);
        $('#ProductID').html(items);
    });

    $('#CategoryID').change(function () {
        console.log(url);
        var url = "/Demo/GetSubCategory";
        var ddlsource = "#CategoryID";
        $.getJSON(url, { CategoryID: $(ddlsource).val() }, function (data) {
            var items = '';
            $("#SubCategoryID").empty();
            $.each(data, function (i, subcategory) {
                items += "<option value='" + subcategory.value + "'>" + subcategory.text + "</option>";
            });
            $('#SubCategoryID').html(items);
        }) .fail(function( jqxhr, textStatus, error ) {
            var err = textStatus + ", " + error;
            console.log( "Request Failed: " + err );
        });
    });

    $('#SubCategoryID').change(function () {
        var url = "/Demo/GetProducts";
        var ddlsource = "#SubCategoryID";
        $.getJSON(url, { SubCategoryID: $(ddlsource).val() }, function (data) {
            var items = '';
            $('#ProductID').empty();
            $.each(data, function (i, product) {
                items += "<option value='" + product.value + "'>" + product.text + "</option>";
            });
            $('#ProductID').html(items);
        });
    });
}());