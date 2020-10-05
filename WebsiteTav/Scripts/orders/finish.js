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
const Type = document.getElementsByClassName("priceInfinish")[0].innerHTML = `${pricOFplan} تومان`;
//document.getElementsByClassName("priceInfinish")[0].innerHTML = format("{0:#,###0.#}", pricOFplan);
//document.getElementsByClassName("priceInfinish")[0].innerHTML = pricOFplan.replace(/(\d{3})(?=\d)/g, '$1.')


document.getElementsByClassName("totalpriceInfinish")[0].innerHTML = `${totalPrice} تومان`;

document.getElementsByClassName("usercount")[1].innerHTML = `سرویس ${userOfPlan} `;
document.getElementsByClassName("periodInfinish")[1].innerHTML = periodOfplan;
document.getElementsByClassName("totalpriceInfinish")[1].innerHTML = `${totalPrice} تومان`;

document.getElementsByClassName("capacity")[0].innerHTML = `${(userOfPlan.match(/(\d+)/)[0]) * (timeOfPlan.match(/(\d+)/)[0])} نفرساعت  `;

//---> string Name
//---> string TellNo
//---> string Description
//---> string Brand
//---> string SocialMediaLink
//---> int    Status

function finishUp() {
    const Name = document.getElementById('txtName').value;
    const TellNo = document.getElementById('txtTel').value;
    const Description = Type;
    const Status = 5;
    const Brand = 'آموزش آنلاین';
    const SocialMediaLink = '';

    if (Name == null) {
        UIkit.notification("لطفا نام خود را وارد کنید")
        return;
    }
    if (TellNo == null) {
        UIkit.notification("شماره تلفن خود را وارد کنید")
        return;
    }
    if (Type == null) {
        UIkit.notification("لطفا یک پلن از مرحله اول انتخاب کنید")
        return;
    }

    const obj = {
        Name: Name,
        TellNo: TellNo,
        Description: Description,
        Status: Status,
        Brand: Brand,
        SocialMediaLink: SocialMediaLink
    }
    const ans = AddStart(obj);
    if (ans !== null) {
        UIkit.modal(document.getElementById('modal-order')).hide();
        UIkit.notification("سفارش شما ثبت شد، به زودی با شما تماس حاصل خواهد شد")
    }
    else {
        UIkit.notification("مشکلی پیش آمد، لطفا بعدا تگرار کنید")
    }
}