////var names =[];
var customers = [];
function add() {
    //var fname = document.getElementById("txtFName").value;
    //var lname = document.getElementById("txtLName").value;
    //var fullname = fname + " " + lname;
    //var result = document.getElementById("resultSection");
    //names.push(fullname);
    //console.log(names);
    //var myElement = "<ul>";
    //for (var i = 0; i < names.length; i++) {
    //    myElement += "<li>" + names[i] + "</li>";
    //}
    //myElement += "</ul>";
    //console.log(myElement);
    //result.innerHTML = myElement;
    var customer = {
        fname: document.getElementById("txtFName").value,
        lname: document.getElementById("txtLName").value,
        age: parseInt(document.getElementById("txtAge").value),
        phone: document.getElementById("txtPhone").value
    };
    customers.push(customer);
    console.log(customers);
    var myTable = document.getElementById("customersTable");
    var newRow = myTable.insertRow();
    var clmName = newRow.insertCell();
    var myData = document.createTextNode(customer.fname + " " + customer.lname);
    clmName.appendChild(myData);
    var clmAge = newRow.insertCell();
    myData = document.createTextNode(customer.age);
    clmAge.appendChild(myData)
    var clmPhone = newRow.insertCell();
    myData = document.createTextNode(customer.phone);
    clmPhone.appendChild(myData);
}
