import { JanuszAngulPage } from './app.po';

describe('janusz-angul App', () => {
  let page: JanuszAngulPage;

  beforeEach(() => {
    page = new JanuszAngulPage();
  });

  it('should display welcome message', done => {
    page.navigateTo();
    page.getParagraphText()
      .then(msg => expect(msg).toEqual('Welcome to app!!'))
      .then(done, done.fail);
  });
});
