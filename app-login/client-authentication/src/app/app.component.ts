import { Component } from '@angular/core';
import { AutenticateService } from './services/autenticate.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'client-authentication';
  constructor(public autenticate:AutenticateService){

  }
}
