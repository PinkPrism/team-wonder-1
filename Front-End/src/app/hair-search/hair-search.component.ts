import { Component, OnInit } from '@angular/core';

import { Observable, Subject } from 'rxjs';

import {
   debounceTime, distinctUntilChanged, switchMap
 } from 'rxjs/operators';

import { Hair } from '../hair';
import { HairService } from '../hair.service';

@Component({
  selector: 'app-hair-search',
  templateUrl: './hair-search.component.html',
  styleUrls: [ './hair-search.component.css' ]
})
export class HairSearchComponent implements OnInit {
  hairs$: Observable<Hair[]>;
  private searchTerms = new Subject<string>();

  constructor(private hairService: HairService) {}

  
  search(term: string): void {
    this.searchTerms.next(term);
  }

  ngOnInit(): void {
    this.hairs$ = this.searchTerms.pipe(
      
      debounceTime(300),

      
      distinctUntilChanged(),

      
      switchMap((term: string) => this.hairService.searchHairs(term)),
    );
  }
}
