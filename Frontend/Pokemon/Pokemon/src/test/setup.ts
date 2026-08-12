// Local API uses a self-signed dev certificate; Node rejects it by default.
process.env.NODE_TLS_REJECT_UNAUTHORIZED = '0';
