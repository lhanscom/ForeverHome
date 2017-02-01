import {Injectable} from '@angular/core';
import {Http} from '@angular/http';
import {HttpHelpers} from '../utils/HttpHelpers';
import {Observable} from 'rxjs/Observable';
import 'rxjs/Rx';

@Injectable()
export class AppServiceDonate extends HttpHelpers {

    private _getDonateUrl = 'Home/GetDonate';

    constructor(private http: Http) {
        super(http);

    }

}