import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { CookieService } from 'angular2-cookie/services/cookies.service';

@Injectable()
export class AuthService implements CanActivate {

    constructor(private cookies: CookieService, private route: Router) { }

    private valuesAuth: string = "false";

    canActivate() {
        this.valuesAuth = this.cookies.get('userAuth');
        if (this.valuesAuth === "true") {
            return true;
        } else {
            this.route.navigate(['/login']);
            return false;
        }
    }

}
