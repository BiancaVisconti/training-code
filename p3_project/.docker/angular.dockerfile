FROM node as base
WORKDIR /app
COPY . .
RUN npm clean-install
RUN npm run build

FROM nginx
COPY --from=base /app/dist/p3project /usr/share/nginx/html
COPY --from=base /app/nginx.conf /etc/nginx/conf.d/default.conf