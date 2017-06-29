import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

@Injectable()
export class StatisticsService {

    constructor(private _http:Http) { }

    //url address to controller
    private urlStatGeneral = '/api/Statistics/StatisticsGeneral';
    private urlStatDay = '/api/Statistics/StatisticsDay';
    private urlStatPeriod = '/api/Statistics/StatisticsPeriod';



    // general statistics for columns
    getStatGeneral() {
        return this._http.get(this.urlStatGeneral).map(this.myData);
    }

    //day statistics for columns
    getStatDay(item: Date) {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this._http.post(this.urlStatDay, JSON.stringify(item),options).map(this.myData)
    }

    //period statistics for columns
    getStatPeriod(item: Date, item2:Date) {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this._http.post(this.urlStatPeriod, JSON.stringify({ 'startTime': item, 'endTime': item2 }), options).map(this.myData);
    }


    private myData(res: Response) {
        let body;
        if (res.text()) {
            body = res.json();
        }
        return body || {};
    }
}
