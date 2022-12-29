FROM node:12
WORKDIR /awstesting
COPY package.json /awstesting
RUN npm install
COPY . /awstesting
CMD node server.js
EXPOSE 8000