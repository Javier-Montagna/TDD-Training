import { TestBed, async } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { DebugElement } from '@angular/core/src/debug/debug_node';
import { By } from "@angular/platform-browser";
import { dispatchEvent } from '@angular/core/src/view/util';

describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        AppComponent
      ],
    }).compileComponents();
  }));
  it('should create the app', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  }));
  it(`should have as title 'app'`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.title).toEqual('app');
  }));
  it('should render title in a h1 tag', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('h1').textContent).toContain('Welcome to app!');
  }));
  it('should render input of type text to enter name', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('#empName') === null).toBe(false);
  }));
  it('should render a label to display the initials', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('#empInitials') === null).toBe(false);
  }));
  it('initial should be empty when name is empty', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    let input: DebugElement = fixture.debugElement.query(By.css('#empName'));
    let label: DebugElement = fixture.debugElement.query(By.css('#empInitials'));

    input.nativeElement.value = '';
    expect(label.nativeElement.textContent).toBe('');
  }));
  it('initial should be JM when name is Javier Montagna', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const input = fixture.debugElement.query(By.css('#empName')).nativeElement;
    const label = fixture.debugElement.query(By.css('#empInitials')).nativeElement;

    fixture.componentInstance.onTextChanged("Javier Montagna");
    fixture.detectChanges();
    expect(label.textContent).toBe('JM');
  }));
  it('initial should be RC when name is Ruth Cubi', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const input = fixture.debugElement.query(By.css('#empName')).nativeElement;
    const label = fixture.debugElement.query(By.css('#empInitials')).nativeElement;

    fixture.componentInstance.onTextChanged("Ruth Cubi");
    fixture.detectChanges();
    expect(label.textContent).toBe('RC');
  }));
  it('initial should be GMdLVelTG when name is German Mutto de Los Valles en la Tierra Genial', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const input = fixture.debugElement.query(By.css('#empName')).nativeElement;
    const label = fixture.debugElement.query(By.css('#empInitials')).nativeElement;

    fixture.componentInstance.onTextChanged("German Mutto de Los Valles en la Tierra Genial");
    fixture.detectChanges();
    expect(label.textContent).toBe('GMdLVelTG');
  }));
  
});
