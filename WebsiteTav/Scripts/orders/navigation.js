function btnChoosePlan_Click() {
    window.location.assign("order.html");
}

let pirce = "";

//localStorage.setItem("VarName", "VarValue");
//localStorage.getItem("VarName");

function periodOfPlan_Click() {
   // debugger;
    const a = localStorage.getItem("priceOfPlan");
    if (a == null || a == "null") {
        UIkit.notification("یکی از پلن ها را انتخاب کنید")
        return;
    }

    window.location.assign("period.html");
}
function finish_Click() {
    window.location.assign("finish.html");
}

//function myfunction() {
//    return "hello";
//} if (myfunction == "hello") {
//    alert('Yes');
//}