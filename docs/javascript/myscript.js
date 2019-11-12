/*Home made Light box for image views*/ 
// Open the Modal
function openModal() {
  document.getElementById("myModal").style.display = "block";
}

// Close the Modal
function closeModal() {
  document.getElementById("myModal").style.display = "none";
}

var slideIndex = 1;
showSlides(slideIndex);

// Next/previous controls
function plusSlides(n) {
  showSlides(slideIndex += n);
}

// Thumbnail image controls
function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("demo");
  var captionText = document.getElementById("caption");
  if (n > slides.length) {slideIndex = 1}
  if (n < 1) {slideIndex = slides.length}
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";
  dots[slideIndex-1].className += " active";
  captionText.innerHTML = dots[slideIndex-1].alt;
}

/*Small functions to play with js*/
//change existing element in website 
function p_tag_resize(){
  document.getElementById('demo1').style.fontSize='35px';
}

//add time and date element in website
function displayDate() {
  document.getElementById("demo2").innerHTML = Date();
}

//change text in existing button 
function change() // no ';' here
{
    var elem = document.getElementById("myButton1");
    if (elem.value=="You Submited") elem.value = "Submit your stuff";
    else elem.value = "You Submited";
}

var cars = ["Saab", "Volvo", "BMW"];
document.getElementById("demo3").innerHTML = cars;