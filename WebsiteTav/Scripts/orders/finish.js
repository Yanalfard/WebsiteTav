const pricOFplan = parseInt(localStorage.getItem("priceOfPlan"));
const userOfPlan = localStorage.getItem("userOfPlan");
const timeOfPlan = localStorage.getItem("timeOfPlan");
const videoOfPlan = localStorage.getItem("videoOfPlan");
const totalPrice = parseInt(localStorage.getItem("totalPrice"));
const periodOfplan = localStorage.getItem("periodOfplan");

document.getElementsByClassName("usercount")[0].innerHTML = userOfPlan;
document.getElementsByClassName("timeINmonth")[0].innerHTML = timeOfPlan;
document.getElementsByClassName("videocount")[0].innerHTML = videoOfPlan;
document.getElementsByClassName("periodInfinish")[0].innerHTML = periodOfplan;
document.getElementsByClassName("priceInfinish")[0].innerHTML = `${pricOFplan} تومان`;
//document.getElementsByClassName("priceInfinish")[0].innerHTML = format("{0:#,###0.#}", pricOFplan);
//document.getElementsByClassName("priceInfinish")[0].innerHTML = pricOFplan.replace(/(\d{3})(?=\d)/g, '$1.')


document.getElementsByClassName("totalpriceInfinish")[0].innerHTML = `${totalPrice} تومان`;

document.getElementsByClassName("usercount")[1].innerHTML = `سرویس ${userOfPlan} `;
document.getElementsByClassName("periodInfinish")[1].innerHTML = periodOfplan;
document.getElementsByClassName("totalpriceInfinish")[1].innerHTML = `${totalPrice} تومان`;

document.getElementsByClassName("capacity")[0].innerHTML = `${(userOfPlan.match(/(\d+)/)[0]) * (timeOfPlan.match(/(\d+)/)[0])} نفرساعت  ` ;

