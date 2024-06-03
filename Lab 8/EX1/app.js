$(document).ready(function () 
  {
    // Check Username
    $("#checkUsername").hide();
    let usernameError = false;
   
    function checkUsername() 
    {
      let usernameValue = $("#usernames").val();
      if (usernameValue.length == "") 
      {
        $("#checkUsername").show();
        usernameError = false;
        return false;
      } 
      else if (usernameValue.length < 3 || usernameValue.length > 10) 
      {
        $("#checkUsername").show();
        usernameError = false;
        // usernameValue.classList.add("is-invalid");
        return false;
      } 
      else if (usernameValue.length > 3 && usernameValue.length < 10) 
      {
        usernameError = true;
        // usernameValue.classList.remove("is-invalid");
        $("#checkUsername").hide();
      }
    }
   
    // Check Email
    function checkEmail()
    {
    const email = document.getElementById("email");
    email.addEventListener("blur", () => 
    {
      let regex = /^([_\-\.0-9a-zA-Z]+)@([_\-\.0-9a-zA-Z]+)\.([a-zA-Z]){2,7}$/;
      let s = email.value;
      if (regex.test(s)) 
      {
        email.classList.remove("is-invalid");
        emailError = true;
      } else if (!regex.test(s)) 
      {
        email.classList.add("is-invalid");
        emailError = false;
      }
    });
  }
   
    // Check Password
    $("#checkPassword").hide();
    let passwordError = false;

    function checkPassword() 
    {
      let passwordValue = $("#password").val();
      let pRegex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{1,}$/;
      if (passwordValue.length == "") 
      {
        $("#checkPassword").show();
        passwordError = false;
        return false;
      }
      if ((passwordValue.length < 3 || passwordValue.length > 10 )|| !pRegex.test(passwordValue)) 
      {
        $("#checkPassword").show();
        $("#checkPassword").css("color", "red");
        passwordError = false;
        // passwordValue.classList.add("is-invalid");
        return false;
      } else if ((passwordValue.length > 3 && passwordValue.length < 10 ) && pRegex.test(passwordValue)) 
      {
        passwordError = true;
        // passwordValue.classList.remove("is-invalid");
        $("#checkPassword").hide();
      }
    }
   
    // Confirm Password
    $("#ConfirmPassword").hide();
    let confirmPasswordError = false;

    function confirmPassword() 
    {
      let confirmPasswordValue = $("#confirmPassword").val();
      let passwordValue = $("#password").val();
      if (passwordValue != confirmPasswordValue) 
      {
        $("#ConfirmPassword").show();
        $("#ConfirmPassword").css("color", "red");
        confirmPasswordError = false;
        // confirmPasswordValue.classList.add("is-invalid");
        return false;
      } else if (passwordValue == confirmPasswordValue) 
      {
        confirmPasswordError = true;
        // confirmPasswordError.classList.remove("is-invalid");
        $("#ConfirmPassword").hide();
      }
    }
   
    // Submission Button
    $("#submitbtn").click(function () 
    {
      checkUsername();
      checkPassword();
      confirmPassword();
      checkEmail();
      if(
        usernameError == true &&
        passwordError == true &&
        confirmPasswordError == true &&
        emailError == true
        && passwordValue == confirmPasswordValue) //not imp but for testing purposes
      {
        return true;
      } 
      else 
      {
        return false;
      }
    });
  });