CREATE SCHEMA test;


ALTER SCHEMA test OWNER TO postgres;


CREATE TABLE test.results (
    result_date date NOT NULL,
    result_value numeric(20,5)
);


ALTER TABLE test.results OWNER TO postgres;
