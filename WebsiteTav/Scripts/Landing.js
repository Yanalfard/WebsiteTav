let SelectedStartItem = '';

//Logic to only allow one item to be focused at a time, and show it's content.
function StartItemEnter(sender)
{
    SelectedStartItem = sender.id;
    let other = document.querySelector(".start-items-item-hover");
    if (other != null)
    {
        other.classList.remove("start-items-item-hover");
    }
    sender.classList.add("start-items-item-hover");

    if (sender.id == "itemMedia")
    {
        let mediatxt = document.getElementById("txtMedia");
        mediatxt.classList.remove("collapsed");

    }
    else
    {
        let mediatxt = document.getElementById("txtMedia");
        mediatxt.classList.add("collapsed");

    }

    //if (sender.id == "itemWeb") {

    //}
    //else if (sender.id == "itemSoftwar") {

    //}
    //else if (sender.id == "itemApp") {

    //}
    //else if (sender.id == "itemNet") {

    //}
    //else if (sender.id == "itemMedia") {
    //    let mediatxt = document.querySelector("#txtMedia");
    //    mediatxt.classList.remove("hidden");
    //}
    //else if (sender.id == "itemGraphic") {

    //}
}

function StartClick()
{
    var other = document.querySelector(".start-items-item-hover");
    if (other == null)
    {
        alert("لطفا یک گزینه را انتخاب کنید");
        return;
    }

    var txtMedias = document.querySelector('#txtMedias');
    var txtBrand = document.querySelector(' #txtBrand');
    var txtDesc = document.querySelector('  #txtDesc');
    var txtTel = document.querySelector('   #txtTel');
    var txtName = document.querySelector('  #txtName');

    if (txtName.value == '')
    {
        alert("لطفا نام و نام خانوادگی خود را وارد نمایید");
        return;
    }
    if (txtTel.value == '')
    {
        alert(" لطفا شماره تلفن خود را وارد نمایید");
        return;
    }
    if (txtTel.value.length != 11)
    {
        alert(" شماره تلفن صحیح نمی باشد");
        return;
    }
    var reg = /^\d+$/;
    if (!reg.test(txtTel.value))
    {
        alert(" شماره تلفن صحیح نمی باشد");
        return;
    }

    if (txtDesc.value == '')
    {
        alert("لطفا توضیحی مختصر درباره پروژه خود ارایه دهید");
        return;
    }
    if (txtBrand.value == '')
    {
        alert("لطفا نام شرکت خود را وارد نمایید");
        return;
    }

    if (SelectedStartItem.id == "itemMedia")
    {
        if (txtMedias.value == '')
        {
            alert("لطفا لینک شبکه اجتماعی خود را وارد نمایید");
            return;
        }
    }

    //---> int    id
    //---> string Name
    //---> string TellNo
    //---> string Description
    //---> string Brand
    //---> string SocialMediaLink
    //---> int    Status
    var object = {
        id: 0,
        Name: txtName.value,
        TellNo: txtTel.value,
        Description: txtDesc.value,
        Brand: txtBrand.value,
        SocialMediaLink: txtMedias.value,
        Status: 0
    }

    const ans = Bjax(Url.concat('/api/StartCore/AddStart'), object, 'LP');
    //const ans = AddStart(object);

    txtMedias.value = '';
    txtBrand.value = '';
    txtDesc.value = '';
    txtTel.value = '';
    txtName.value = '';

}

function EmailCoop()
{
    const coopName = document.querySelector("#coopName");
    const coopTellNo = document.querySelector("#coopTellNumber");

    if (coopName.value == "")
    {
        alert("نام و نام خانوادگی خود را وارد نماییید");
        return;
    }
    if (coopTellNo.value == "")
    {
        alert("شماره تلفن خود را وارد نمایید");
        return;
    }
    if (coopTellNo.value.length != 11)
    {
        alert(" تعداد اعداد شماره تلفن صحیح نمی باشد");
        return;
    }
    var reg = /^\d+$/;
    if (!reg.test(coopTellNo.value))
    {
        alert(" شماره تلفن صحیح نمی باشد ");
        return;
    }

    const obj = {
        Name: coopName.value,
        TellNo: coopTellNo.value
    }
    console.log(AddCoop(obj));

    coopTellNo.value = "";
    coopName.value = "";
}
