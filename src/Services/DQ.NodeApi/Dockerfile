FROM node

# Install app dependencies
WORKDIR /src
COPY . .
WORKDIR "/src/src/Services/DQ.NodeApi"
RUN yarn

RUN yarn build

EXPOSE 80
CMD [ "yarn", "start" ]
