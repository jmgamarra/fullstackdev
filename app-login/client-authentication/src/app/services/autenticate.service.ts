import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { user } from 'src/model/user';

@Injectable({
  providedIn: 'root'
})
export class AutenticateService {

  private readonly mockUser = new user("test@gmail.com", "123456");

  isAutenticated = false;
  constructor(private router: Router) { }
  login(usuario: user): boolean {
    if (this.checkCredential(usuario)) {
      this.isAutenticated = true;      
      this.router.navigate(['home']);
      alert('Welcome');
      return true;
    } else {
      this.isAutenticated = false;
      alert('Error');
      return false;
    }
  }
  checkCredential(usuario: user): boolean {
    return this.checkEmail(usuario.getEmail()) && this.checkPassword(usuario.getPassword());
  }
  checkEmail(email: string): boolean {
    return email === this.mockUser.getEmail();
  }
  checkPassword(password: string): boolean {
    
    return password === this.mockUser.getPassword();
  }
}
