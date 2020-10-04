
function periodPrice() {
    let d = parseInt(document.getElementById("periodOfservice").value);
    //console.log(d);
    //if (d == 1) {

    //    totalPrice.innerHTML = 1 * pricOFplan;

    //}
    //if (d == 3) {
    //    totalPrice.innerHTML = 3 * pricOFplan;
    //}
    //if (d == 6) {
    //    totalPrice.innerHTML = 4 * pricOFplan;
    //}
    //if (d == 9) {
    //    totalPrice.innerHTML = 9 * pricOFplan;
    //}
    //debugger;
    const pricOFplan = parseInt(localStorage.getItem("priceOfPlan"));

    let price = 0;
    switch (d) {
        case 1:
            price = 1 * pricOFplan;
            break;
        case 3:
            price = 3 * pricOFplan;
            break;
        case 6:
            price = 6 * pricOFplan;
            break;
        case 9:
            price = 9 * pricOFplan;
            break;
        default:
    }
    document.getElementById("totalPrice").innerHTML = price;
    localStorage.setItem("totalPrice", price);
    console.log(price);
    localStorage.setItem("periodOfplan", d +'ماهه');
}