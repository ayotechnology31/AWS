function validateItems(){
  var name = document.forms["contactUs"]["name"].value;
  var email = document.forms["contactUs"]["email"].value;
  var textarea = document.forms["contactUs"]["textarea"].value;
  var checkbox = document.forms["contactUs"]["checkbox"].value;

  if (name == "" ) {
        alert("Name must be filled in.");
        document.forms["contactUs"]["name"]
           .parentElement.className = "form-group has-error";
        document.forms["contactUs"]["name"].focus();
        return false;
    }
    if (email == "" ) {
          alert("Email must be filled in.");
          document.forms["contactUs"]["email"]
             .parentElement.className = "form-group has-error";
          document.forms["contactUs"]["email"].focus();
          return false;
      }
      if (textarea == "" ) {
            alert("Additional Information must be filled in.");
            document.forms["contactUs"]["textarea"]
               .parentElement.className = "input-group-prepend has-error";
            document.forms["contactUs"]["textarea"].focus();
            return false;
        }
        if (checkbox == checked ) {
              alert("Please check which day we can contact you.");
              document.forms["contactUs"]["checkbox"]
                 .parentElement.className = "form-check form-check-inline has-error";
              document.forms["contactUs"]["checkbox"].focus();
              return false;
          }
    return false;
}
