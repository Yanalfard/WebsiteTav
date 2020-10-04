localStorage.setItem("priceOfPlan", null);

try {
    var slider = document.getElementById("myRange");
    var output = document.getElementById("outvalue");
    output.innerHTML = slider.value;

    slider.oninput = function () {
        if (slider.value > 5 && slider.value <= 50) {
            let x = document.getElementById("ser-one");
            x.style.display = "grid";
            document.getElementById("ser-two").style.display = "none"
            document.getElementById("ser-three").style.display = "none"
            document.getElementById("ser-four").style.display = "none"
            output.innerHTML = this.value + ' ' + 'نفر' + ' ' + 'در رنج ' + ' ' + ' 5 تا 50 نفر'
            // output.innerHTML = '1' + ' ' + 'تا' + ' ' + this.value + ' '+ 'نفر';

        }
        if (slider.value >= 51 && slider.value <= 100) {
            let y = document.getElementById("ser-two");
            y.style.display = "grid";
            document.getElementById("ser-one").style.display = "none"
            document.getElementById("ser-three").style.display = "none"
            document.getElementById("ser-four").style.display = "none"
            output.innerHTML = this.value + ' ' + 'نفر' + ' ' + 'در رنج ' + ' ' + ' 51 تا 100 نفر'
            //output.innerHTML = '41' + ' ' + 'تا' + ' ' + this.value + ' ' + 'نفر';
        }
        if (slider.value >= 101 && slider.value <= 150) {
            let y = document.getElementById("ser-three");
            y.style.display = "grid";
            document.getElementById("ser-one").style.display = "none"
            document.getElementById("ser-two").style.display = "none"
            document.getElementById("ser-four").style.display = "none"
            output.innerHTML = this.value + ' ' + 'نفر' + ' ' + 'در رنج ' + ' ' + ' 101 تا 150 نفر'
            //output.innerHTML = '81' + ' ' + 'تا' + ' ' + this.value + ' ' + 'نفر';
        }
        if (slider.value >= 151 && slider.value <= 200) {
            let y = document.getElementById("ser-four");
            y.style.display = "grid";
            document.getElementById("ser-one").style.display = "none"
            document.getElementById("ser-two").style.display = "none"
            document.getElementById("ser-three").style.display = "none"
            output.innerHTML = this.value + ' ' + 'نفر' + ' ' + 'در رنج ' + ' ' + ' 151 تا 200 نفر'
            //output.innerHTML = '121' + ' ' + 'تا' + ' ' + this.value + ' ' + 'نفر'  ;

        }


    }

} catch (e) {
    console.log('Err')
}



function selectPlan(btn) {
    const price = btn.getAttribute("price");
    const user = btn.getAttribute("user");
    const time = btn.getAttribute("time");
    const video = btn.getAttribute("video");
    console.log(`${price} - ${user} - ${time} - ${video}`)

    localStorage.setItem("priceOfPlan", price);
    localStorage.setItem("userOfPlan", user);
    localStorage.setItem("timeOfPlan", time);
    localStorage.setItem("videoOfPlan", video);
    window.location.assign("period.html");
}
