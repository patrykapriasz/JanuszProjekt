import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';

@Injectable()
export class ChartsService {

  constructor(private _http: Http) { }

    private dateUrl = "/api/Columns/MethanolDate";
    private strengthUrl = "/api/Columns/MethanolStrength";

    getDate() {
        return this._http.get(this.dateUrl).map(this.myData);
    }

    getStrength() {
        return this._http.get(this.strengthUrl).map(this.myData);
    }

    private myData(res: Response) {
        let body;
        if (res.text()) {
            body = res.json();
        }
        return body || {};
    }
}
