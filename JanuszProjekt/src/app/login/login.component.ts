import { Component, OnInit } from '@angular/core';
import { trigger, state, style, transition, animate, keyframes, group } from '@angular/animations';
import { LoginService } from '../services/login.service';


@
Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css'],
    providers: [LoginService],
    animations: [
        trigger('flipState',
        [
            state('active',
                style({
                    transform: 'rotate(360deg)'
                })),

            state('inactive', style({
              transform: 'rotate(0deg)'
          })),
          transition('active => inactive', animate('1100ms ease-out')),
          transition('inactive => active', animate('1100ms ease-in'))
      ]),

        trigger('fadeInAnimation', [

            // route 'enter' transition
            transition(':enter', [

                // css styles at start of transition
                style({ opacity: 0 }),

                // animation and styles at end of transition
                animate('.45s', style({ opacity: 1 }))
            ]),
        ]),

        trigger('enter', [
            state('in',style({
                transform: 'translateX(0)'
            })),
            transition('void=>*', [
            style({
                transform:'translateX(90%)'
            }), animate(900)])
        ])


  ]
})
export class LoginComponent implements OnInit {

  constructor(private _service:LoginService) { }
  flip: string = 'inactive';

  toggleFlip() {
      this.flip = (this.flip == 'inactive') ? 'active' : 'inactive';
  }

    login(email: string, password: string) {
        this._service.login(email, password);
    }

  ngOnInit() {

  }

}
