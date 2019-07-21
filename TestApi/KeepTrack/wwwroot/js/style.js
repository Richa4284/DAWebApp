
function myFunction() {
  if (document.getElementById('wrapper').style.display === 'none') {
      document.getElementById('wrapper').style.display = 'block';
    } else {
      document.getElementById('wrapper').style.display = 'none';
    }
}
function rotate(){
  document.getElementById('formContainer').style.transform= 'rotateY( 180deg )' ;
}

function revRotate(){
  document.getElementById('formContainer').style.transform= 'rotateY( 0 )' ;
}

function dropdown(){
var acc = document.getElementsByClassName("accordion");
          var i;

          for (i = 0; i < acc.length; i++) {
            acc[i].addEventListener("click", function() {
              this.classList.toggle("active");
              var panel = this.nextElementSibling;
              if (panel.style.display === "block") {
                panel.style.display = "none";
              } else {
                panel.style.display = "block";
              }
            });
          }
}

function details(){
  var agent=document.getElementsByClassName("agents");
  var i;
  
  for(i=0; i<agent.length ; i++){
    agent[i].addEventListener("click",function(){
      var tab=document.getElementById("agdetails");
      tab.classList.toggle("transform-active");
      tab.textContent=this.textContent;
    });
    
  }

}





