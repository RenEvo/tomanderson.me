---

---
Create Repository

Create gh-pages branch

Set new branch to default.

Delete master branch.

Map the @ record in DNS to the 204.232.175.78

https://help.github.com/articles/setting-up-a-custom-domain-with-pages#setting-the-domain-in-your-repo




Add CNAME to root with domain name.

Wait a while for site to update.

Install Ruby

https://www.ruby-lang.org/en/downloads/

RubyInstaller

http://rubyinstaller.org/downloads/

I installed 1.9.3

I also checked the option to include it in my windows path (easier)

Install 4.5.2 DevKit (from ruby downloads)

Initialize DevKit

https://github.com/oneclick/rubyinstaller/wiki/Development-Kit

navigate to extracted directory:

ruby dk.rb init

ruby dk.rb install

Verify that devkit is in path variable, or run the devkitvars.bat (optional)

Add the Gemfile

gem install bundler

navigate to repo

bundle install (if invalid cert, change https to http in gemfile for source) *adds a gemfile.lock

run site: bundle exec jekyll serve (ctrl+c to stop)

http://localhost:4000

Add a _config.yml

 - This is also a great place to define any variables that you want to use.
 
Create some directory structure

http://jekyllrb.com/docs/structure/

install boostrap (and theme it i would suppose)

create the default _layout

create the home page

create some other pages (about/contact/posts)

create the posts _layout

etc....

** TODO **




