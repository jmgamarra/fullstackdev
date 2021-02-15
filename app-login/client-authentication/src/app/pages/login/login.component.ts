import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AutenticateService } from 'src/app/services/autenticate.service';
import { user } from 'src/model/user';
import * as CryptoJS from 'crypto-js';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  msgErrorEmail:string='';
  msgErrorPassword:string='';     
  constructor(private autenticateService: AutenticateService) { }

  ngOnInit(): void {
  }
  onSubmit(sigInForm: NgForm) {
    //console.log(sigInForm);
    //let keyGen='miclave';
   //let encTXT= CryptoJS.AES.encrypt(sigInForm.value.email.trim(),sigInForm.value.password.trim());
//    var encrypted = CryptoJS.DES.encrypt(sigInForm.value.password.trim(), "Secret Passphrase");
// ​
// var decrypted = CryptoJS.DES.decrypt(encrypted, "Secret Passphrase");
// console.log(decrypted.value);

    const usuario = new user(sigInForm.value.email, sigInForm.value.password);
    
    if(this.checkInputs(usuario.getEmail(),usuario.getPassword())){
      
      this.autenticateService.login(usuario);
    }    
  }
  checkInputs(email:string,password:string){
    this.msgErrorEmail = "";
    this.msgErrorPassword= "";
    let flag =true;
    if(email.length === 0)
    {
      this.msgErrorEmail = "please enter email id";                  
      flag=false;
    }
    
    if (password.length === 0) {
      this.msgErrorPassword = "please enter password";            
      flag=false;
    }

    if (password.length < 6)
    {
      this.msgErrorPassword = "password should be at least 6 char";           
      flag=false;
    }
    
    return flag;
  }
}
