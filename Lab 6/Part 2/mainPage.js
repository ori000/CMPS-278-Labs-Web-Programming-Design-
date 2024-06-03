
function slider() { 
    var slider = document.getElementById('sliderOne').value;
    if(slider === "1"){
        document.getElementById('Image').src = '../images/tshirt.jpg';
        document.getElementById('colorName').innerText = "Black"
        document.getElementById('colorIndicator').value = "Black"

    }
    if(slider === "2"){
        document.getElementById('Image').src = '../images/pinktshirt.jpg';
        document.getElementById('colorName').innerText = "Pink"
        document.getElementById('colorIndicator').value = "Pink"

    }
    if(slider === "3"){
        document.getElementById('Image').src = '../images/blueTshirt.jpg';
        document.getElementById('colorName').innerText = "Blue"
        document.getElementById('colorIndicator').value = "Blue"
    }
}
function checkText() {
    var textCheck = document.getElementById('textCheck');
    var text = document.getElementById('text');
    if(textCheck.checked){
        text.removeAttribute("readonly");
        text.classList.remove('invalid');
    }
    else{
        text.value="";
        text.setAttribute("readonly", "readonly");
        text.classList.add('notReady');
    }
}
function checkImage() {
    var imageCheck = document.getElementById('imageCheck');
    var image = document.getElementById('image');
    if(imageCheck.checked){
        image.removeAttribute("readonly");
        image.classList.remove('invalid');
    }
    else{
        image.value="";
        image.setAttribute("readonly", "readonly");
        image.classList.add('invalid');
    }
}
