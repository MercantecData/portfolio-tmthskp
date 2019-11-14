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
function p_tag_resize()
{
  size = document.getElementById('demo1').style.fontSize='30px';
}

//add time and date element in website
function displayDate() 
{
  document.getElementById("demo2").innerHTML = Date();
}

//remove element on website
function removeDate()
{
  var element = document.getElementById("demo2");
  element.parentNode.removeChild(element);
}

//change text in existing button 
function change() // no ';' here
{
    var elem = document.getElementById("myButton1");
    if (elem.value=="You Submited") elem.value = "Submit your stuff";
    else elem.value = "You Submited";
    
    //js take input from html formular and put in id for read og web page
    var x =  
    document.getElementById("myText1", "myText2").value; 
    document.getElementById("demo4").innerHTML = x; 
}

//Js array
function myArray()
{
  elements = ["Element1", "Element2", "Element3", "Element4"];
  document.getElementById("demo3").innerHTML = elements;
}

//Js add element to array 
function addToArray() 
{
  elements.push("Element5");
  document.getElementById("demo3").innerHTML = elements;
}

//Js remove element from array
function removeFromArray()
{
elements.pop();
document.getElementById("demo3").innerHTML = elements;
}

/****** For Jquery play dpart ******/
function animation1(navn,x,y,z, w, h)
{
	$('#'+navn).animate({left: x, top: y, opacity: z, width: w, height: h}, 1000);//Animation object at 1000 miliseconds = 1 sec
}
		
function animation2(navn,x,y,z, w, h, p)
{
	$('#'+navn).animate({left: x, top: y, opacity: z, width: w, height: h, padding: p}, 300);
}

//fade in
function komind(){
  $("#div1").fadeIn();
  $("#div2").fadeIn("slow");
  $("#div3").fadeIn(2500);
}

//fade out
function smutud(){
  $("#div1").fadeOut();
  $("#div2").fadeOut("slow");
  $("#div3").fadeOut(2500);
}

//toggle slide
function bold(){
  $("#bold1").slideToggle();
}