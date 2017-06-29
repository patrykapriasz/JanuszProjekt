import { Component, OnInit } from '@angular/core';
import { Http, Response } from '@angular/http';
import {Observable} from 'rxjs/Observable';
import "rxjs";
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    title = 'app';
    online$: Observable<boolean>;

    constructor(private _http: Http) {
        this.online$ = Observable.merge(
            Observable.of(navigator.onLine),
            Observable.fromEvent(window, 'online').map(() => true),
            Observable.fromEvent(window, 'offline').map(() => false));
    }

    ngOnInit() {
        

    }

    

    private myData(res: Response) {
        let body;
        if (res.text()) {
            body = res.json();
        }
        return body || {};
    }
}


