import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { Router } from '@angular/router';
//import { CookieService } from 'angular2-cookie/core';

import { CookieService } from 'ngx-cookie';
import 'rxjs/Rx';

@Injectable()
export class LoginService {

    constructor(private _http: Http, private route: Router, private cookie: CookieService) { }

    private url = '/api/Login/loginToApp';
    public loginStatus: boolean = false;

    login(email: string, pass: string) {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this._http.post(this.url, JSON.stringify({ 'UserEmail': email, 'UserPassword': pass }), options)
            .map(this.myData).subscribe(res => {
            this.loginStatus = res;
                this.checkCookie();;

            });

    }

    logout() {
        this.loginStatus = false;
        this.cookie.put("userAuth", 'false');
        this.route.navigate(['/login']);
    }

    checkCookie() {
        if (this.loginStatus) {
            this.cookie.put("userAuth", 'true');
            this.redirect();
        }
    }

    private redirect() {
        this.route.navigate(['/home']);
    }

    private myData(res: Response) {
        let body;
        if (res.text()) {
            body = res.json();
        }
        return body || {};
    }

}
