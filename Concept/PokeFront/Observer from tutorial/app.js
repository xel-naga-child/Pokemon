// const section = document.querySelector('#my-work');
const images = document.querySelectorAll('#my-work img');

const observer = new IntersectionObserver((entries) => {

    if(entries[0].isIntersecting) {
        console.log('section is visible');
        entries[0].target.classList.add('show');
    }else{
        console.log('section is not visible');
        entries[0].target.classList.remove('show');
    }

}, 
{
    rootMargin: '0px 0px 0px 400px'
})

// observer.observe(section);
images.forEach((image) => {
    observer.observe(image);
})