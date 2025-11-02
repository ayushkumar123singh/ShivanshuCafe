const slides = document.querySelectorAll(".banner-slider .slide");
const dotsContainer = document.querySelector(".slider-dots");
let index = 0;

slides.forEach(() => dotsContainer.innerHTML += "<span></span>");
const dots = dotsContainer.querySelectorAll("span");

function changeSlide() {
    slides.forEach(s => s.classList.remove("active"));
    dots.forEach(d => d.classList.remove("active-dot"));

    slides[index].classList.add("active");
    dots[index].classList.add("active-dot");

    index = (index + 1) % slides.length;
}

changeSlide();
setInterval(changeSlide, 3500);


