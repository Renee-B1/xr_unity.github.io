
// animate on scroll for about
window.addEventListener('load', function () { AOS.init(); });


// panels at bottom of page
const panels = document.querySelectorAll('.panel');

panels.forEach(function (panel) {
    panel.addEventListener('mouseover', function () {
        removeActiveClasses();
        panel.classList.add('active');
    });
});

function removeActiveClasses() {
    panels.forEach(function (panel) {
        panel.classList.remove('active');
    });
}


// making top bar visible after a scroll point
const top_bar = document.getElementById("top_bar")

// top_bar.currentTarget.className += ''

// top_bar.addEventListener('scroll', (event) => {
//     top_bar.className.remove('hidden');

// })




// https://stackoverflow.com/questions/59428035/how-to-implement-nested-collapsibles
// start
var allHeights = 0;
var contents = document.getElementsByClassName("content");
var j;

for (j = 0; j < contents.length; j++) {
  var h = document.getElementsByClassName("content")[j].scrollHeight;
  allHeights += h;
}

var coll = document.getElementsByClassName("collapsible");
var i;

for (i = 0; i < coll.length; i++) {
  coll[i].addEventListener("click", function() {
    this.classList.toggle("active");
    var content = this.nextElementSibling;
    if (content.style.maxHeight == allHeights + "px"){
      content.style.maxHeight = "0px";
    } else {
      content.style.maxHeight = allHeights + "px";
    }
  });
}
// end