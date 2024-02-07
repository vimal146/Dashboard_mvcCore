//(function () {
//    'use strict';

//    angular
//        .module('app')
//        .controller('HomeInvoiceController', HomeInvoiceController);

//    HomeInvoiceController.$inject = ['$scope'];

//    function HomeInvoiceController($scope) {
//        $scope.title = 'HomeInvoiceController';

//        activate();

//        function activate() { }
//    }
//})();


//(function () {
//    app.controller('HomeInvoice', function ($scope, $http, $filter) {
//        $scope.Sale = new Object();
//        $scope.InvoiceCart = [];
//        var init = function () {
//            GetProducts();
//        }; //end of init
//        init(); //init is called

//        function GetProducts() {
//            $http.get('/Home/GetAllProduct')
//                .then(function (response) {
//                    var data = response.data;
//                    $scope.ProductList = data;
//                });
//        }
//        $scope.AddNewRow = function () {
//            $scope.InvoiceCart.push({ ProductId: null, CategoryName: '', UnitPrice: 0, Quantity: 1, LineTotal: 0 });
//        }
//        $scope.SetValueOfProduct = function (productId) {
//            var dataObj = $filter('filter')($scope.ProductList, { ProductId: parseInt(productId) })[0];
//            const index = $scope.InvoiceCart.findIndex((x) => x.ProductId === productId);
//            $scope.InvoiceCart[index].CategoryName = dataObj.CategoryName;
//            $scope.InvoiceCart[index].UnitPrice = dataObj.SalesPrice;
//            $scope.InvoiceCart[index].LineTotal = $scope.InvoiceCart[index].UnitPrice * $scope.InvoiceCart[index].Quantity;
//        }
//        $scope.OnChangeLineTotalSet = function (productId) {
//            const index = $scope.InvoiceCart.findIndex((x) => x.ProductId === productId);
//            $scope.InvoiceCart[index].LineTotal = $scope.InvoiceCart[index].UnitPrice * $scope.InvoiceCart[index].Quantity;
//        }
//        $scope.SubTotalCalculation = function () {
//            $scope.Sale.Subtotal = 0;
//            for (var i = 0; i < $scope.InvoiceCart.length; i++) {
//                $scope.Sale.Subtotal = $scope.Sale.Subtotal + $scope.InvoiceCart[i].LineTotal;
//            }
//        }
//        $scope.CalculateDiscount = function () {
//            $scope.Sale.DiscountAmount = ($scope.Sale.Subtotal * $scope.Sale.DiscountParcentage) / 100;
//        }
//        $scope.CalculateVat = function () {
//            $scope.Sale.VatAmount = (($scope.Sale.Subtotal - $scope.Sale.DiscountAmount) * $scope.Sale.VatParcentage) / 100;
//            //$scope.Sale.TotalAmount = ($scope.Sale.Subtotal - $scope.Sale.DiscountAmount) + $scope.Sale.VatAmount;
//            //$scope.Sale.TotalAmout = ($scope.Sale.Subtotal - $scope.Sale.DiscountAmount) + $scope.Sale.VatAmount;
//        }
//        $scope.RowDelete = function (index) {
//            if (index > -1) {
//                $scope.InvoiceCart.splice(index, 1);
//            }
//            $scope.SubTotalCalculation();
//        }
//        $scope.SaveInvoice = function () {
//            $scope.Sale.OrderNo = $("#OrderNo").val();
//            var data = JSON.stringify({
//                sale: $scope.Sale, salesDetails: $scope.InvoiceCart
//            });
//            return $.ajax({
//                contentType: 'application/json; charset=utf-8',
//                dataType: 'json',
//                type: 'POST',
//                url: "/Home/SaveInvoiceSale",
//                data: data,
//                success: function (result) {
//                    if (result.IsSuccess == true) {

//                        //Reset();
//                        alert("Save Success!");
//                    }
//                    else {
//                        alert("Save failed!");
//                    }
//                },
//                error: function () {
//                    alert("Error!")
//                }
//            });
//        }
//    });
//}).call(angular);






function GetPrint() {
    /*For Print*/
    window.print();
}

function BtnAdd() {
    /*Add Button*/
    var v = $("#TRow").clone().appendTo("#TBody");
    $(v).find("input").val('');
    $(v).removeClass("d-none");
    $(v).find("th").first().html($('#TBody tr').length - 1);
}

function BtnDel(v) {
    /*Delete Button*/
    $(v).parent().parent().remove();
    GetTotal();

    $("#TBody").find("tr").each(
        function (index) {
            $(this).find("th").first().html(index);
        }

    );
}

function Calc(v) {
    /*Detail Calculation Each Row*/
    var index = $(v).parent().parent().index();

    var qty = document.getElementsByName("qty")[index].value;
    var rate = document.getElementsByName("rate")[index].value;

    var amt = qty * rate;
    document.getElementsByName("amt")[index].value = amt;

    GetTotal();
}

//function GetTotal() {
//    /*Footer Calculation*/

//    var sum = 0;
//    var amts = document.getElementsByName("amt");

//    for (let index = 0; index < amts.length; index++) {
//        var amt = amts[index].value;
//        sum = +(sum) + +(amt);
//    }

//    document.getElementById("FTotal").value = sum;

//    var gst = document.getElementById("FGST").value;
//    var net = +(sum) + +(gst);
//    document.getElementById("FNet").value = net;

//}


//document.addEventListener("input", function (event) {
//    if (event.target.classList.contains("qty-input") || event.target.classList.contains("sale-price-input")) {
//        updateTotalAmount(event.target);
//    }
//});

//function updateTotalAmount(inputField) {

//    const row = inputField.getAttribute("data-row");
//    const qtyInput = document.getElementById(`qty_${row}`);
//    const salePriceInput = document.getElementById(`salePrice_${row}`);
//    const amtInput = document.getElementById(`amt_${row}`);
    

//    const qty = parseFloat(qtyInput.value) || 0;
//    const salePrice = parseFloat(salePriceInput.value) || 0;


//    const totalAmount = qty * salePrice;
//    amtInput.value = totalAmount.toFixed(2);// Format the total amount to two decimal places


//    // Calculate the total amount by summing up all item amounts
//    let calculatedTotalAmount = 0;
//    const amtInputs = document.querySelectorAll(".amt-input");
//    amtInputs.forEach(function (input) {
//        calculatedTotalAmount += parseFloat(input.value) || 0;
//    });

//    // Update the Total input field with the calculated total
//    const totalAmountInput = document.getElementById("totalAmountInput");
//    totalAmountInput.value = calculatedTotalAmount.toFixed(2); // Format the total amount to two decimal places


//}

// Define a function that will be called when a mutation is observed
//function handleMutations(mutationsList, observer) {
//    // Check for specific changes you are interested in
//    mutationsList.forEach((mutation) => {
//        if (mutation.type === "childList") {
//            // Handle the DOM changes here
//            // This is where you can update the total amount
//            updateTotalAmount();
//        }
//    });
//}

//// Create a MutationObserver
//const observer = new MutationObserver(handleMutations);

//// Start observing changes in a specific element or the entire document
//// For example, to observe the entire document:
//observer.observe(document, { childList: true, subtree: true });

// Function to calculate and update the overall total amount
//function calculateOverallTotal() {
//    let overallTotal = 0;

//    // Loop through all rows and sum up the total amounts
//    for (let i = 1; i <= rowCounter; i++) {
//        const amtInput = document.getElementById(`amt_${i}`);
//        if (amtInput) {
//            overallTotal += parseFloat(amtInput.value) || 0;
//        }
//    }

//    // Update the "Total" input field with the overall total
//    const totalAmountInput = document.getElementById("totalAmountInput");
//    if (totalAmountInput) {
//        totalAmountInput.value = overallTotal.toFixed(2);
//    }
//}
