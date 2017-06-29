import { Injectable } from '@angular/core';
import {Http, Response} from '@angular/http';

@Injectable()
export class DashboardService {

    constructor(private _http: Http) { }

    private termalUrl = "/api/Dashboard/getTermalTemp";
    private methanolUrl ='/api/Dashboard/getMethanolStrength';

    getTermalTemp() {
        return this._http.get(this.termalUrl).map(this.myData);
    }

    getMethanolStrength() {
        return this._http.get(this.methanolUrl).map(this.myData);
    }

    private myData(res: Response) {
        let body;
        if (res.text()) {
            body = res.json();
        }
        return body || {};
    }

}
