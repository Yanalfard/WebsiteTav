function SubmitHelp() {
    txtName = document.querySelector("#txtName");
    //txtCompany = document.querySelector("#txtCompany");
    txtEmail = document.querySelector("#txtEmail");
    txtText = document.querySelector("#txtText");

    if (txtName.value == '') {
        alert('لطفا نام و نام خانوادگی خود را وارد نمایید');
        return;
    }
    //if (txtText.value == '') {
    //    alert('لطفا نام  شرکت خود را وارد نمایید');
    //    return;
    //}
    if (txtEmail.value == '') {
        alert('لطفا ایمیل خود را وارد نمایید');
        return;
    }
    if (txtText.value == '') {
        alert('لطفا توضیحی مختصر درباره موضوع مشاوره خود بنویسید ');
        return;
    }

    var object = {
        Name: txtName.value,
        Email: txtEmail.value,
        Description: txtText.value
    }

    AddHelp(object);
}