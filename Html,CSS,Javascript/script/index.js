//ProductUpdate
function productUpdate() {

    $("#nameErrorMessage").html("");
    $("#emailErrorMessage").html("");
    $("#websiteErrorMessage").html("");
    $("#imageLinkErrorMessage").html("");
    $("#errorMessage").html("");

    const nameValue = $("#name").val();
    const emailValue = $("#email").val();
    const websiteValue = $("#website").val();
    const imageLinkValue = $("#imageLink").val();
  
    if (nameValue && emailValue && websiteValue && imageLinkValue) {
      if (!validateName(nameValue)) {
        document.getElementById("nameErrorMessage").innerHTML = "*Name cannot contain numbers";
      } 
      if (!validateEmail(emailValue)) {
        document.getElementById("emailErrorMessage").innerHTML = "*Email is Invalid";
      }
      if (!validateWebsite(websiteValue)) {
        document.getElementById("websiteErrorMessage").innerHTML = "*Website URL is Invalid";
      }
      if (!validateImageLink(imageLinkValue)) {
        document.getElementById("imageLinkErrorMessage").innerHTML = "*Image URL is Invalid";
      } 
      else {
        const newProduct = new Product($("#name").val(), genderChoice(), $("#email").val(), $("#website").val(), skillChoices(), $("#imageLink").val());
        newProduct.addToTable();
        formClear();
        document.getElementById("errorMessage").innerHTML = "";
      }
    } 
    else {
      document.getElementById("errorMessage").innerHTML = "*Please Fill all the fields!";
    }
  }

//Class to add new Product
let count=0;
class Product {
    constructor(name, gender, email, website, skills, imageLink) {
      this.name = name;
      this.gender = gender;
      this.email = email;
      this.website = website;
      this.skills = skills;
      this.imageLink = imageLink;
    }
  
    addToTable() {
      var genderOutput = this.gender;
      var skillOutput = this.skills;
      if ($("#productTable tbody").length == 0) {
        $("#productTable").append("<tbody></tbody>");
      }
      // Even row elements 
      if (count % 2 == 0) {
        $("#productTable tbody").append("<tr>" + "<td id='newData' class='animated fadeIn' style='height:100px'>" + "<b>" + this.name + "</b>" + "<br>" +
          genderOutput + "<br>" + this.email + "<br>" + '<a href="' + this.website + '" target="_blank" style="color:blue">' + this.website + "</a>" + "<br>" + skillOutput
          + "</td>" + "<td id='newData' class='animated fadeIn'>" + '<p>' + '<img src="'
          + this.imageLink + '" alt="'+ this.name+' Image" title="Click to open in new tab" style="width:125px;height:100px"></p>' + "</td>" + "</tr>");
  
      }
      // Odd Row elements 
      else {
        $("#productTable tbody").append("<tr>" + "<td id='newData' class='animated fadeIn' >" + "<b>" + this.name + "</b>" + "<br>" +
          genderOutput + "<br>" + '<a href="' + this.website + '" target="_blank" style="color:blue">' + this.website + "</a>" + "<br>" + this.email + "<br>" + skillOutput
          + "</td>" + "<td id='newData' class='animated fadeIn'>" + '<p >' + '<img src="'
          + this.imageLink + '" alt="'+ this.name+' Image" title="Click to open in new tab" style="width:125px;height:100px"></p>' + "</td>" + "</tr>");
      }
      count++;
    }
}
//Function to validate Name
function validateName(name) {
    if (/[\d]/.test(name)) {
        return false; // Contains a digit
    } else {
        return true; // Does not contain a digit
    }
}
//Function to validate Email
function validateEmail($email) {
    var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;
    return emailReg.test($email);
}
// Function to validate website URL
function validateWebsite(url) {
    const urlRegex = /^(http|https|ftp):\/\/[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$/i;
    return urlRegex.test(url);
}
// Function to validate image link
function validateImageLink(url) {
    const urlRegex = /^(http|https|ftp):\/\/[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$/i;
    return urlRegex.test(url);
}


// Gives the checked radio key of gender
function genderChoice() {
    const choices = $('input[name="genderChoice"]');
  
    let selectedValue;
    for (const choice of choices) {
      if (choice.checked) {
        selectedValue = choice.value;
        break;
      }
    }
    return selectedValue;
  }
  
// Gives the skill choices made by user
function skillChoices() {
    const choices = $('input[name="skillChoice"]');
    let selectedValue = [];
    for (const choice of choices) {
      if (choice.checked) {
        selectedValue.push(choice.value);
      }
    }
    return selectedValue.toString();
  }
  
// Clears the form fields
function formClear() {
    $("#name").val("");
    $("#nameErrorMessage").html("");
    $("#email").val("");
    $("#emailErrorMessage").html("");
    $("#website").val("");
    $("#websiteErrorMessage").html("");
    $("#imageLink").val("");
    $("#imageLinkErrorMessage").html("");
    $("#male").prop("checked", true);
    $("#java").prop("checked", true);
    $("#html").prop("checked", false);
    $("#css").prop("checked", false);
    $("#errorMessage").html("<br>");
}