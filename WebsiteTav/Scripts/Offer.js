function AddOffer()
{
    const Name = document.getElementById('txtName').value;
    const TellNo = document.getElementById('txtTel').value;
    const Description = document.getElementById('txtDesc').value;
    const Brand = document.getElementById('txtBrand').value;

    if (Name == '')
    {
        UIkit.notification("لطفا نام و نام خانوادگی خود را وارد نمایید");
        return;
    }
    if (TellNo == '')
    {
        UIkit.notification(" لطفا شماره تلفن خود را وارد نمایید");
        return;
    }
    if (TellNo.length != 11)
    {
        UIkit.notification(" شماره تلفن صحیح نمی باشد");
        return;
    }
    var reg = /^\d+$/;
    if (!reg.test(TellNo))
    {
        UIkit.notification(" شماره تلفن صحیح نمی باشد");
        return;
    }

    if (Description == '')
    {
        UIkit.notification("لطفا توضیحی مختصر درباره پروژه خود ارایه دهید");
        return;
    }
    if (Brand == '')
    {
        UIkit.notification("لطفا نام شرکت خود را وارد نمایید");
        return;
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
        Name: Name,
        TellNo: TellNo,
        Description: Description,
        Brand: Brand
    }
    const ans = Bjax(Url.concat('/api/StartCore/AddStart'), object, 'LP');

    console.log(ans);

    UIkit.modal(document.getElementById('order')).hide();
    UIkit.notification("ثبت شد");

}