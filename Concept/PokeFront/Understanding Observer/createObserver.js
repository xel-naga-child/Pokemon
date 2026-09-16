let root = document.querySelector('#scrollArea');

const options = {
    root: root,
    rootMargin: '0px',
    scrollMargin: '0px',
    threshold: 1.0
}

const appendParagraph = () => {

    let target = document.querySelector('#target');
    if (target && target.id) target.id = "";

    for (let i = 0; i < 10; i++) {

        let p = document.createElement('p');
        p.innerText =`Scroll down to see the observer pattern in action ${Date.now()}.`;

        root.appendChild(p);

        if (i === 9)  p.id = "target";
        
    }
    
    console.log(root.childNodes.length);
}

callback = (entries, observer) => {

    entries.forEach((entry) => {
        console.log("Element is fully visible in screen");
        console.log("Entry:", entry);
    });
    
    console.log("Observer:", observer);
    appendParagraph();
}
    
const observer = new IntersectionObserver(callback, options);
let target = document.querySelector('#target');
observer.observe(target);
